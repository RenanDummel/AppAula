$(document).ready(function () {
    load();
});
function load() {
    let id = window.location.toString().split('/').pop();
    if (id && id.toLowerCase() !== 'formulario') {
        CidadeBuscaPorId(id).then(function (obj) {
            $('#cep').val(obj.cep);
            $('#uf').val(obj.uf);
            $('#municipio').val(obj.municipio);
        });
    }
}
function salvar() {
    let obj = {
        cep: ($("[name='cep']").val() || ''),
        uf: ($("[name='uf']").val() || ''),
        municipio: ($("[name='municipio']").val() || '')
    };
    let id = window.location.toString().split('/').pop();
    if (id && id.toLowerCase() !== 'formulario') {
        obj.id = id;
    }
    CidadeSalvar(obj).then(function () {
        window.location.href = '/cidade';
    }, function (err) {
        alert(err);
    });
}