$(document).ready(function () {
    load();
    loadCidades();
});
function load() {
    let id = window.location.toString().split('/').pop();
    if (id && id.toLowerCase() !== 'formulario') { 
        UsuariosBuscaPorId(id).then(function (obj) {
            $('#nome').val(obj.nome);
            $('#email').val(obj.email);
            $('#senha').val(obj.senha);
            $('#cidadeid').val(obj.cidadeid);
        });
    }
}

function salvar() {
    let obj = {
        nome: ($("[name='nome']").val() || ''),
        email: ($("[name='email']").val() || ''),
        senha: ($("[name='senha']").val() || ''),
        cidadeid: ($("[id='cidade-select']").val() || '')
    };
    let id = window.location.toString().split('/').pop();
    if (id && id.toLowerCase() !== 'formulario') {
        obj.id = id;
    }
    UsuariosSalvar(obj).then(function () {
        window.location.href = '/usuarios';
    }, function (err) {
        alert(err);
    });
}


function loadCidades() { debugger
    CidadeListaCidade().then(function (data) {
        debugger
        $('#cidade-select').empty();
        data.forEach(obj => {
            $('#cidade-select').append('<option value="' + obj.id + '">' + obj.municipio + '</option>');
        });
    });
}
