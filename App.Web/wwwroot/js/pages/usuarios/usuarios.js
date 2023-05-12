$(document).ready(function () {
    load();
});

function load() {
    UsuariosListaUsuarios().then(function (data) {
        $('#table tbody').html('');
        data.forEach(obj => {

            let btnRemover = '<button class="btn btn-danger" onclick="remover(\'' + obj.id + '\')">Remover</button>';
            let btnEditar = '<button class="btn btn-info" onclick="window.location.href = \'/usuarios/formulario/' + obj.id + '\'"><i class="fas fa-pencil-alt"></i>Editar</button>';

            $('#table tbody').append('' +
                '<tr id="obj-' + obj.id + '">' +
                '<td>' + (obj.nome || '--') + '</td>' +
                '<td>' + (obj.email || '--') + '</td>' +
                '<td>' + btnEditar + btnRemover + '</td>' +
                '</tr>')
        });
    });
}

function remover(id) {
    UsuariosRemover(id).then(function () {
        alert('Usuário removido com sucesso');
        load();
    });
}