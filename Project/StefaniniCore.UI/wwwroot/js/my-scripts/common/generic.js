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

            alert(data.message);

            if (data.refreshPage) {
                window.location.reload(false);
            }
        },
        error: function (data) {

            if (data && data.responseJSON.message) {

                if (data.responseJSON.urlToRedirect)
                    window.location = data.responseJSON.urlToRedirect;
                else
                    alert(data.responseJSON.message + " [" + data.status + "]");

            } else {
                var message = "Erro ocorreu no envio da requisição. Tente mais tarde.";
                alert(message);
            }
        }
    });
}