$(document).ready(function () {
  $("#Prueba").submit(function (e) {
    const datos = {
      nombre: $("#txt_Nombre").val(),
      apellido: $("#txt_Apellido").val(),
      correo: $("#txt_Correo").val(),
      cedula: $("#txt_cedula").val(),
      txt_direccion: $("#txt_direccion").val(),
      telefono: $("#txt_Telefono").val(),
    }; 
    $.ajax({
        type: 'post',
        url: '~/TallerMecanica.App.Persistencia/AppRepositorios/',
        data: datos,
        success(data){
            if (data == 'pass') {
                alert('guardado');
            } else {
                alert('error');
            }
        },
        error(){

        }
    });

    e.preventDefault();
  });
});
