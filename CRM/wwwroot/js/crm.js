
$(document).ready(reloadCustomerRecord())
    function reloadCustomerRecord() {
        $.ajax({
            url: 'Home/GetAllCuatomer',
            success: function (list) {
                $.each(list, function (li, i) {
                    $("#customerlist").append("<tr><td><span class='readmode'>" + (li + 1) + "</span><input type='hidden' id='cid' value='" + i.customerId + "' class='hiden'/></td><td><span class='readMode'>" + i.customerName + "</span><input type='text' id='name' value='" + i.customerName + "' class='hiden editmode'/></td><td><span class='readMode'>" + i.customerEmail + "</span><input type='email' id='email' value='" + i.customerEmail + "' class='hiden editmode' /></td><td><span class='readMode'>" + i.customerPhone + "</span><input type='number' id='phone' value='" + i.customerPhone + "' class='hiden editmode' /></td><td><span class='readMode'>" + i.customerAddress + "</span><textarea id='address' class='hiden editmode'>" + i.customerAddress + "</textarea></td><td><input type='button' class='btn btn-primary readMode' value='Edit' id='btnedit'/><input type='button' class='hiden btn btn-primary editmode' value='Cansel' id='btncnl'/></td><td><input type='button' class='btn btn-primary readMode' value='Delete' id='btndel'/><input type='button' class='btn btn-primary editmode hiden' value='Update' id='btnupd'/></td></tr>");
                });
            },
            Error: function (err) { alert(err); }
        });
    }


    $("#customerlist").on("click", "#btndel", function () {
        var id = $("#cid").val();
        $.ajax({
            url: 'Home/Delete',
            data: { customerId: id },
            success: function () { reloadCustomerRecord(); },
            Error: function (err) { alert(err.Message); }
        })
    })



    $("#customeradd").click(function () {
        var cname = $("#cName").val();
        var cemail = $("#cEmail").val();
        var cphone = $("#cPhone").val();
        var caddress = $("#cAddress").val();
        debugger;
        $.ajax({
            url: 'Home/Add',
            data: { CustomerName: cname, CustomerEmail: cemail, CustomerPhone: cphone, CustomerAddress: caddress },
            success: function (result) {
                $("#customerlist").append("<tr><td><input type='hidden' id='cid' value='' class='hiden'/></td><td><span class='readMode'>" + cname + "</span><input type='text' id='name' value='" + cname + "' class='hiden editmode'/></td><td><span class='readMode'>" + cemail + "</span><input type='email id='email' value='" + cemail + "' class='hiden editmode' /></td><td><span class='readMode'>" + cphone + "</span><input type='number' id='phone' value='" + cphone + "' class='hiden editmode' /></td><td><span class='readMode'>" + caddress + "</span><textarea id='address' class='hiden editmode'>" + caddress + "</textarea></td><td><input type='button' class='btn btn-primary readMode' value='Edit' id='btnedit'/><input type='button' class='btn btn-primary editmode hiden' value='Cansle' id='btncnl'/></td><td><input type='button' class='btn btn-primary readMode' value='Delete' id='btndel'/><input type='button' class='btn btn-primary editmode hiden' value='Update' id='btnupd' /></td></tr>");
                $("#customeraddtbl").reset();
            },
            Error: function () { alert("0") }
        })
    })

    $("#customerlist").on("click", "#btnedit", function () {
        $(this).closest("tr").find(".readMode").hide();
        $(this).closest("tr").find(".editmode").show();

    })
    $("#customerlist").on("click", "#btncnl", function () {
        $(this).closest("tr").find(".readMode").show();
        $(this).closest("tr").find(".editmode").hide();
    })


$("#customerlist").on("click", "#btnupd", function () {
    var raw = $(this).closest("tr");
        var id = $(raw).find("#cid").val();
        var name = $(raw).find("#name").val();
        var email = $(raw).find("#email").val();
        var phone = $(raw).find("#phone").val();
        var address = $(raw).find("#address").val();
        debugger;
        $.ajax({
            url: 'Home/Update',
            data: { customerId: id, CustomerName: name, CustomerEmail: email, CustomerPhone: phone, CustomerAddress: address },
            success: function (result) {
                reloadCustomerRecord();
                $(".readMode").show();
                $(".editmode").hide();
            },
            Error: function (err) { alert(err); }
        })
    })

