$(document).ready(function () {
    load();
});

function load() {
    CidadeListaCidade().then(function (data) {
        $('#table tbody').html('');
        data.forEach(obj => {

            let btnRemover = '<button class="btn btn-danger" onclick="remover(\'' + obj.id + '\')">Remover</button>';
            let btnEditar = '<button class="btn btn-info" onclick="window.location.href = \'/cidade/formulario/' + obj.id + '\'"><i class="fas fa-pencil-alt"></i>Editar</button>';

            $('#table tbody').append('' +
                '<tr id="obj-' + obj.id + '">' +
                '<td>' + (obj.cep || '--') + '</td>' +
                '<td>' + (obj.uf || '--') + '</td>' +
                '<td>' + (obj.municipio || '--') + '</td>' +
                '<td>' + btnEditar + btnRemover + '</td>' +
                '</tr>')
        });
    });
}

function remover(id) {
    CidadeRemover(id).then(function () {
        alert('Cidade removida com sucesso');
        load();
    });
}