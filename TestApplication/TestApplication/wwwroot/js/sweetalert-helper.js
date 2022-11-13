/// <reference path="sweetalert2.js" />
// alert types warning, error, success, info, and question
function alertWarning(title, text) {
    swal({
        type: "warning",
        title: `${title}`,
        html: `${text}`,
        showConfirmButton: true
    });
}
function alertError(title, text) {
    swal({
        type: "error",
        title: `${title}`,
        html: `${text}`,
        showConfirmButton: true
    });
}

function alertSuccess(title, text) {
    swal({
        type: "success",
        title: `${title}`,
        html: `${text}`,
        showConfirmButton: true,
    });
}

function alertInfo(title, text) {
    swal({
        type: "info",
        title: `${title}`,
        html: `${text}`,
        showConfirmButton: true
    });
}

function alertInfo(title, text, callback) {
    swal({
        reverseButtons: true,
        title: `${title}`,
        html: `${text}`,
        type: 'info',
        showCancelButton: true,
        confirmButtonClass: "btn-primary",
        cancelButtonColor: '#d33',
        confirmButtonText: 'OK',
        cancelButtonText: "Cancel",
    }).then((result) => {
        if (result.value) {
            if (typeof callback !== "undefined") {
                callback();
            }
        }
        return;
    });
}

function alertQuestion(title, text, callback) {
    swal({
        reverseButtons: true,
        title: "Please Confirm !",
        html: `<h5> ${text} </h5>`,
        type: 'question',
        showCancelButton: true,
        confirmButtonClass: "btn-primary",
        cancelButtonColor: '#d33',
        confirmButtonText: 'OK',
        cancelButtonText: "Cancel",
    }).then((result) => {
        if (result.value) {
            callback();
        }
        return;
    });
}
