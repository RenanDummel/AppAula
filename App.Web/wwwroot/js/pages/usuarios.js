$(document).ready(function () {
    laod();
});

function load() {
    UsuarioListaUsuarios().then(function (data) {
        data.forEach(obj => {
            $('#table tbody').append('' +
                '<tr id="obj-' + obj.id + '">' +
                '<td>' + (obj.nome || '--') + '</td>' +
                '<td>' + (obj.email || '--') + '</td>' +
                '<td>' + (obj.senha || '--') + '</td>' +
                '</tr>')
        });
    });
}