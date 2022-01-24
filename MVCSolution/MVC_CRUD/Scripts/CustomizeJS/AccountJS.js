/*! v2.2.0 | (c) 2022 Account For ForgetPassword */

$(document).ready(function () {
    $("#btnShowModal").click(function () {
        $("#loginModal").modal('show');
    });
    $("#btnHideModal").click(function () {
        $("#loginModal").modal('hide');
    });
});

$('#btnSave').click(function (e) {
    console.log(e);
    e.preventDefault(); // <------------------ stop default behaviour of button
    
    var email_mobile = $("#txtEmailMobile").val();
    debugger;

    $.ajax({
        url: rootDir + "Customer/Login/ForgetPassward",
        type: "POST",
        //data: JSON.stringify({ 'Options': someData }),
        data: JSON.stringify({ "Email_Mobile": email_mobile }),
        dataType: "json",
        traditional: true,
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            console.log(data);
            debugger;
            if (data.status == "Success") {
                $("#lbldisplay").text(data.MSG);
                //$("#loginModal").modal('hide');               
            } else {
                alert("Error occurs on the Database level!");
                $("#loginModal").modal('show');
            }
        },
        error: function () {
            alert("An error has occured!!!");
        }
    });
});

function PartialNPILookUPPopUpScreen(SearchKey, KeyName) {

    alert(SearchKey + ", " + KeyName + ",Rootdir :" + rootDir);
}