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
            $("#modalClaseGym").modal('show');//despliega el modal 
            console.log(moment(info.dateStr).format("YYYY-MM-DD")/*info.dateStr*/);
            console.log(moment(info.dateStr).format("YYYY-MM-DD")/*info.dateStr*/);
            // change the day's background color just for fun
            //info.dayEl.style.backgroundColor = 'red';
        },
        eventClick: function (info) {
            $("#IdClaseGym1").val(info.event.id);
            $("#Fecha1").val(moment(info.event.start).format("YYYY-MM-DD"));
            $("#HoraInicio1").val(info.event.extendedProps.horaInicio);
            $("#HoraFinal1").val(info.event.extendedProps.horaFinal);
            $("#IdActividad1").val(info.event.extendedProps.idActividad);
            $("#IdSala1").val(info.event.extendedProps.idSala);
            $("#Cupo1").val(info.event.extendedProps.cupo);
            $("#IdEmpleado1").val(info.event.extendedProps.idEmpleado);
            if (info.event.extendedProps.estado == "Activo") {
                $("#Estado1").prop("checked", true);
            } else {
                $("#Estado2").prop("checked", true);
            }


            console.log(info.event.id);
            console.log(info.event.extendedProps.horaInicio);
            console.log(info.event.extendedProps.horaFinal);
            console.log(info.event.extendedProps);
            //alert('Event: ' + info.event.title);
            $("#modalClaseGymDetalle").modal('show');

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
    let formularioClasesGym = $("#formularioClasesGym").serialize();
    $.ajax({
        url: '/ClasesGym/Guardar',
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
        url: '/ClasesGym/Listar',
        type: 'get',
        dataType: 'json'
    }).done(function (respuesta) {
        if (respuesta.status) {
            let data = [];
            respuesta.data.map(function (e) {
                data.push({
                    id: e.idClaseGym,
                    title: e.nActividad,
                    start: moment(e.fecha).format('YYYY-MM-DD') + " " + e.horaInicio,
                    end: moment(e.fecha).format("YYYY-MM-DD") + " " + e.horaFinal,
                    extendedProps: {
                        idActividad: e.idActividad,
                        horaInicio: e.horaInicio,
                        horaFinal: e.horaFinal,
                        idSala: e.idSala,
                        sala: e.nSala,
                        cupo: e.cupo,
                        idEmpleado: e.idEmpleado,
                        empleado: e.nEmpleado,
                        estado: e.estado
                    },

                });

            });
            //$("#calendar").FullCalendar('render');
            //refrescarCalendario(data)
            calendar.addEventSource(data);
        }
    })
}
function borrar() {
    let formularioClasesGym = $("#formularioClasesGymDetalle").serialize();
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
                url: '/ClasesGym/Borrar',
                type: 'delete',
                data: formularioClasesGym,
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
    let formularioClasesGym = $("#formularioClasesGymDetalle").serialize();
    $.ajax({
        url: '/ClasesGym/Modificar',
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