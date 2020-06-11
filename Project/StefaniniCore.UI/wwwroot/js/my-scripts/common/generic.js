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

            if (data.urlToRedirect) {
                window.location = data.urlToRedirect;
                return;
            }
            console.info('[' + data.statusCode + '] ' + data.message);
            alert(data.message);

            if (data.refreshPage) {
                window.location.reload(false);
            }
        },
        error: function (data) {

            if (data && data.responseJSON.message) {

                if (data.responseJSON.urlToRedirect)
                    window.location = data.responseJSON.urlToRedirect;
                else {
                    console.error('[' + data.status + '] ' + data.responseJSON.message);
                    alert(data.responseJSON.message);
                }

            } else {
                var message = 'Erro ocorreu no envio da requisição. Tente mais tarde.';
                console.error('[' + data.status + '] ' + message);

                alert(message);
            }
        }
    });
}