function SendRequest(urlRequest) {
    var dataResult = null;
    method = "GET";
    $.ajax({
        type: method,
        cache: false,
        async: false,
        contentType: "application/json;charset=utf-8",
        url: urlRequest,
    }).done(function (resultApi) {
        dataResult = resultApi;
    }).fail(function (xhr) {
        console.log(xhr.responseJSON.Message + ": " + xhr.statusText);
    });
    return dataResult;
}

//-------------------------------------------------------------------------------
function ValidateData(html) {

    let arr = html.querySelectorAll(".required")

    debugger

    for (let i of arr) {
        let a = isEmpty(i.nextElementSibling.children[0]?.children[0]?.value)
        let b = isEmpty(i.nextElementSibling.children[0]?.children[0]?.children[0]?.value)
        let c = isEmpty(i.nextElementSibling.children[0]?.children[0]?.children[0]?.children[0]?.value)
        if (a && b && c) {
            Notification("warning", "Thông báo", `Vui lòng điền ${i.innerText}`);
            return false;
        }
    }

    return true;
}

//-------------------------------------------------------------------------------
function Notification(type, title, msg) {
    title = isEmpty(title) ? "Thông báo" : title;

    toastr.options = {
        "closeButton": true,
        "progressBar": true,
        "preventDuplicates": true,
        "positionClass": "toast-top-right",
        "showDuration": "400",
        "hideDuration": "1000",
        "timeOut": "4000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    };

    if (type === "success") {
        toastr.success(".:: " + msg + " ::.", "<strong style=\"color:white\">" + title + "</strong></br>");
    }
    else if (type === "warning") {
        toastr.warning(".:: " + msg + " ::.", "<strong style=\"color:white\">" + title + "</strong></br>");
    }
    else {
        toastr.error(".:: " + msg + " ::.", "<strong style=\"color:white\">" + title + "</strong></br>");
    }
}

//-------------------------------------------------------------------------------
function isEmpty(value) {
    return value === undefined || value === null || value === '';
}