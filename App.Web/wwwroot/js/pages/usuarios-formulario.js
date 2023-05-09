function salvar() {
    let obj = {
        cep: ($("[name='nome']").val() || ''),
        nome: ($("[name='email']").val() || ''),
        uf: ($("[name='senha']").val() || ''),
    };
    CidadesSalvar(obj).then(function () {
        window.location.href = '/usuarios';
    }, function (err) {
        alert(err);
    });
}