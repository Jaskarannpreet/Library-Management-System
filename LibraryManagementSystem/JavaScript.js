$(document).ready(function () {


    let a = $(".active").val();
    console.log(a);

    let form = $('#UserTypeForm');
    form.empty();
    $("<lable>").text('Email').attr('class', 'lablestyle').appendTo(form);
    $("<input>").attr('type', 'text').attr('placeholder', 'Enter Your Email').attr('runat', 'server').attr('class', 'inputstyle').attr('id', 'Email').appendTo(form);
    $("<br>").appendTo(form);
    $("<lable>").text('Password').attr('class', 'lablestyle').appendTo(form);
    $("<input>").attr('type', 'text').attr('placeholder', 'Enter Your Password').attr('runat', 'server').attr('class', 'inputstyle').attr('id', 'Password').appendTo(form);


    $("input[name=usertype]").click(function () {
        $("input[name=usertype]").removeClass("active");
        $(this).addClass("active");

        let a = $(".active").val();
        console.log(a)

        let form = $('#UserTypeForm');
        form.empty();
        $("<lable>").text('Email').attr('class', 'lablestyle').appendTo(form);
        $("<input>").attr('type', 'text').attr('placeholder', 'Enter Your Email').attr('class', 'inputstyle').attr('id', 'Email').appendTo(form);
        $("<br>").appendTo(form);
        $("<lable>").text('Password').attr('class', 'lablestyle').appendTo(form);
        $("<input>").attr('type', 'text').attr('placeholder', 'Enter Your Password').attr('class', 'inputstyle').attr('id', 'Password').appendTo(form);
        return false;
    });


    $("input[name=login]").click(function () {
        let UserType = $(".active").val();
        console.log(a)
        let UserEmail = $('#Email').val();
        let UserPassward = $('#Password').val();
        console.log(UserEmail)
        console.log(UserPassward)
        $.ajax({
            type: 'POST',
            url: "Login.aspx/ValidateLogin",
            dataType: "json",
            data: "{'UserType':'" + UserType + "','UserEmail':'" + UserEmail + "','UserPassward':'" + UserPassward + "'}",
            contentType: "application/json",
            success: function (data) {
                var obj = data.d;
                if (obj == true) {

                    alert("loginsuccessful");
                    window.location.href = "index.aspx";
                }
                else {
                    alert("loginfail")
                }
            },
            error: function () {
               
                alert("error");
            }
        });
    });
    $('input[id=Back]').click(function () {
        window.location.href = "index.aspx";
    });
    $('#AddGenre').click(function () {
        window.location.href = "addgenre.aspx";
    });
    $('input[id=AddBook]').click(function () {
        window.location.href = "addbooks.aspx";
    });
    $('input[id=AllStudent]').click(function () {
        window.location.href = "allstudents.aspx";
    });
    $('input[id=AddStudent]').click(function () {
        window.location.href = "addstudents.aspx";
    });
    $('input[id=IssuedBooks]').click(function () {
        window.location.href = "issuedbooks.aspx";
    });
    
});

