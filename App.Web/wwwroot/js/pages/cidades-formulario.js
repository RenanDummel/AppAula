function salvar() {
    let obj = {
        cep: ($("[name='cep']").val() || ''),
        nome: ($("[name='cep']").val() || ''),
        uf: ($("[name='cep']").val() || ''),
    };
    CidadesSalvar(obj).then(function () {
        window.location.href = '/cidades';
    }, function (err) {
        alert(err);
    });
}