
   function MandatoryFieldsCheck(FormId) {
        var unChosenDropDowns = $(FormId + ' .required :selected').text();
    if (unChosenDropDowns.indexOf('বাছাই') !== -1) {
        alertWarning("সমস্ত বাধ্যতামূলক ফিল্ড পূরণ করা হয় নাই", '');
    return false;
            }

    // Checking empty text inputs
    var fields = $(FormId + ' .required input');
    for (var i = 0; i < fields.length; i++) {
                if ($(fields[i]).prop('type') == 'text' && $(fields[i]).val() == "" && !$(fields[i]).hasClass('chosen-search-input')) {
        alertWarning("সমস্ত বাধ্যতামূলক ফিল্ড পূরণ করা হয় নাই", '');
    return false;
                }
            }

    // Checking empty text areas
    var textAreas = $(FormId + ' .required textarea');
    for (var i = 0; i < textAreas.length; i++) {
                if ($(textAreas[i]).val() == "") {
        alertWarning("সমস্ত বাধ্যতামূলক ফিল্ড পূরণ করা হয় নাই", '');
    return false;
                }
            }

    return true;
}

function readUserPictureURL(input, fieldId, buttonId) {
    console.log(input.files[0].name);
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        var ext = input.files[0].name.split(".");
        ext = ext[ext.length - 1].toLowerCase();
        var arrayExtensions = ["jpg", "jpeg", "png", "bmp", "gif"];
        if (arrayExtensions.lastIndexOf(ext) == -1) {
            alert("Wrong extension type.");
            $('#' + buttonId).val("");
            $('#' + fieldId).removeAttr("src");
            $('#' + fieldId + 'Div').addClass("img-container-div-border");
            return false;
        } else {
            reader.onload = function (e) {
                $('#' + fieldId)
                    .attr('src', e.target.result)
                    .width(80)
                    .height(100);
            };
            if ($('#' + fieldId + 'Div').hasClass("img-container-div-border"))
                $('#' + fieldId + 'Div').removeClass("img-container-div-border");
            reader.readAsDataURL(input.files[0]);
        }
    }
}
