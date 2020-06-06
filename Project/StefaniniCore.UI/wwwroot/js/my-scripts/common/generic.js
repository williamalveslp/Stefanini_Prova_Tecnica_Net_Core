function AjaxPostGenerics(data, url, idElementToUpdate, method = 'POST') {

    $.ajax({
        type: method,
        url: url,
        cache: false,
        async: true,
        data: data,
        beforeSend: function () {
            // start loading
        },
        complete: function () {
            // close loading
        },
        success: function (data) {

            if (idElementToUpdate)
                idElementToUpdate.val(data.id);

            alert(data.message);

            if (data.refreshPage) {
                window.location.reload(false);
            }
        },
        error: function (data) {

            if (data && data.message) {

                if (data.statusCode === 400) {        // Bad Request
                    data.message = "Erro ocorreu no envio da requisição [400].";

                } else if (data.statusCode === 403) { // Forbidden.
                    data.message = "Erro ocorreu no envio da requisição [403].";
                }
                alert(data.message);

            } else {
                var message = "Erro ocorreu no envio da requisição. Tente mais tarde.";
                alert(message);
            }
        }
    });
}