var calendar = null;
function calendario() {
    let calendario = document.getElementById("calendar");
    calendar = new FullCalendar.Calendar(calendario, {
        locale: 'es',
        headerToolbar: {
            left: 'prev,next today',
            center: 'title',
            right: 'dayGridMonth,timeGridWeek,timeGridDay,listMonth'
        },
        buttonIcons: true, // show the prev/next text
        weekNumbers: false,
        navLinks: true, // can click day/week names to navigate views
        editable: false,
        dayMaxEvents: true,
        eventColor: '#378006',
        loading: function (bool) {
            document.getElementById('loading').style.display =
                bool ? 'block' : 'none';
        },
        dateClick: function (info) {
            console.log("Hola");
            $("#Fecha").val(moment(info.dateStr).format("YYYY-MM-DD"));//seleciona la fecha y la asigna a Fecha
            $("#modalClaseGuarderia").modal('show');//despliega el modal 
            console.log(moment(info.dateStr).format("YYYY-MM-DD")/*info.dateStr*/);
            console.log(moment(info.dateStr).format("YYYY-MM-DD")/*info.dateStr*/);
            // change the day's background color just for fun
            //info.dayEl.style.backgroundColor = 'red';
        },
        eventClick: function (info) {
            $("#IdClaseGuarderia1").val(info.event.id);
            $("#Fecha1").val(moment(info.event.start).format("YYYY-MM-DD"));
            $("#HoraInicio1").val(info.event.extendedProps.horaInicio);
            $("#HoraFin1").val(info.event.extendedProps.horaFin);
            //$("#IdEmpleado1").val(info.event.extendedProps);
            //$("#IdEmpleado2").val(info.event.extendedProps.idActividad);
            //let _find = info.event.id;
            //$("#IdEmpleado1").val("option:Empleadoid" == _find);
            //function prueba(e) {
            //    let empleado = $(e).find("option== ${info.event.id}");
            //    $("#Empleadoid").val(empleado.attr(""));
            //}
            //    $("#Estado1").prop("checked", true);
            //} else {
            //    $("#Estado2").prop("checked", true);
            //}
            $("#Cupo1").val(info.event.extendedProps.cupo);
            $("#Estado1").val(info.event.extendedProps.estado );
            
            
            console.log(info.event);
            console.log(info.event.id);
            console.log(info.event.extendedProps.horaInicio);
            console.log(info.event.extendedProps.horaFin);
            console.log(info.event.extendedProps);
            //alert('Event: ' + info.event.title);
            $("#modalClaseGuarderiaDetalle").modal('show');

            // change the border color just for fun
            //info.el.style.borderColor = 'red';
        }
    });
    calendar.render();
}

function refrescarCalendario() {
    setTimeout(function () {
        window.location.reload();
    }, 2000);

}
function guardar() {
    let formularioClasesGym = $("#formularioClasesGuarderia").serialize();
    $.ajax({
        url: '/ClasesGuarderia/Guardar',
        type: 'post',
        data: formularioClasesGym,
        dataType: 'json'
    }).done(function (respuesta) {

        if (respuesta.status) {
            Swal.fire({
                position: 'center',
                icon: 'success',
                title: 'Se creó la clase correctamente.',
                showConfirmButton: false,
                timer: 3000
            })
            refrescarCalendario()
            //$("#formularioClasesGym").modal('hide');
        } else {
            Swal.fire({
                icon: 'error',
                title: 'No se pudo crear la clase',
                text: '¡Verifique que los datos de los campos sean correctos!',
            })

        }

    })
}
function mostrar() {
    $.ajax({
        url: '/ClasesGuarderia/Listar',
        type: 'get',
        dataType: 'json'
    }).done(function (respuesta) {
        if (respuesta.status) {
           
            let data = [];
            
            respuesta.data.map(function (e) {
                data.push({
                    id: e.idClaseGuarderia,
                    title: "Clase",
                    start: moment(e.fecha).format('YYYY-MM-DD') + " " + e.horaInicio,
                    end: moment(e.fecha).format("YYYY-MM-DD") + " " + e.horaFin,
                    extendedProps: {
                        horaInicio: e.horaInicio,
                        horaFin: e.horaFin,
                        fecha: e.fecha,
                        cupo: e.cupo,
                        //claseguarderiaEmpleados: { empleadoId =e.idEmpleado },
                        estado: e.estado
                    },

                });

            });
            console.log(data);
            //$("#calendar").FullCalendar('render');
            //refrescarCalendario(data)
            calendar.addEventSource(data);
        }
    })
}
function borrar() {
    let formularioClases = $("#formularioClasesGuarderiaDetalle").serialize();
    Swal.fire({
        title: '¿Está seguro(a) de eliminar?',
        text: "¡No podrá recuperar esta Clase!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Sí, eliminar!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: '/ClasesGuarderia/Borrar',
                type: 'delete',
                data: formularioClases,
                dataType: 'json'
            }).done(function (respuesta) {
                if (respuesta.status) {
                    Swal.fire({
                        position: 'center',
                        icon: 'success',
                        title: 'Clase eliminada correctamente.',
                        showConfirmButton: false,
                        timer: 3000,
                    })
                    refrescarCalendario()

                }

            })

        }
    })

}
function editar() {
    let formularioClasesGym = $("#modalClaseGuarderiaDetalle").serialize();
    $.ajax({
        url: '/ClasesGuarderia/Modificar',
        type: 'post',
        data: formularioClasesGym,
        dataType: 'json'
    }).done(function (respuesta) {
        if (!respuesta.status == true) {
            Swal.fire({
                position: 'center',
                icon: 'success',
                title: 'Se editó la clase correctamente.',
                showConfirmButton: false,
                timer: 3000
            })
            refrescarCalendario()

        } else {//Si result = false, osea no editó porque el modelo no es valido, mande sweetAlert
            Swal.fire({
                icon: 'error',
                title: 'No se pudo editar clase',
                text: '¡Verifique que los datos de los campos sean correctos!',
            })

        }
    })
}