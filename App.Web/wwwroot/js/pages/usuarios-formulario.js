function salvar() { debugger
    let obj = {
        nome: ($("[name='nome']").val() || ''),
        email: ($("[name='email']").val() || ''),
        senha: ($("[name='senha']").val() || '')
    };
    UsuariosSalvar(obj).then(function () {
        window.location.href = '/usuarios';
    }, function (err) {
        alert(err);
    });
}