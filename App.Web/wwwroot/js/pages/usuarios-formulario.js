function salvar() {
    let obj = {
        nome: ($("[name='nome']").val() || ''),
        email: ($("[name='email']").val() || ''),
        senha: ($("[name='senha']").val() || ''),
    };
    CidadesSalvar(obj).then(function () {
        window.location.href = '/usuarios';
    }, function (err) {
        alert(err);
    });
}