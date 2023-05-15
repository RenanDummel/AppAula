$(document).ready(function () {
    load();
});
function load() {
    let id = window.location.toString().split('/').pop();
    if (id && id.toLowerCase() !== 'formulario') { 
        UsuariosBuscaPorId(id).then(function (obj) {
            $('#nome').val(obj.nome);
            $('#email').val(obj.email);
            $('#senha').val(obj.senha);
        });
    }
}

function salvar() {
    let obj = {
        nome: ($("[name='nome']").val() || ''),
        email: ($("[name='email']").val() || ''),
        senha: ($("[name='senha']").val() || '')
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