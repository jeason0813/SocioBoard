﻿var bindmessageajax = '';
var bindprofilesajax = '';
var bindSentmessagesajax = '';

var arrid = new Array();

var arrmsgtype = new Array();

//function BindMessages() {


//    try {
//        bindSentmessagesajax.abort();
//    } catch (e) {

//    }
//    bindmessageajax = $.ajax
//        ({
//            type: "POST",
//            url: "../Message/AjaxMessage.aspx?op=bindMessages",
//            data: '',
//            contentType: "application/json; charset=utf-8",
//            dataType: "html",
//            success: function (msg) {
//                $("#inbox_msgs").html(msg);
//                $(".loaderwrapper").css("display", "none");

//                UpdateReadStatus();


//            }
//        });


//}


//function BindArchiveMessages() {

//    //        try {
//    //            bindSentmessagesajax.abort();
//    //        } catch (e) {

//    //        }
//    $("#sent_messages").removeClass('active');
//    $("#smart_inbox").removeClass('active');
//    $("#archive_message").addClass('active');
//    $(".right-sidebar1").hide();
//    bindmessageajax = $.ajax
//        ({
//            type: "POST",
//            url: "../Message/AjaxMessage.aspx?op=bindarchive",
//            data: '',
//            contentType: "application/json; charset=utf-8",
//            dataType: "html",
//            success: function (msg) {
//                $("#inbox_msgs").html(msg);
//                $("#home_loader").hide();
//                $(".loaderwrapper").css("display", "none");
//                //  UpdateReadStatus();


//            }
//        });
//}

//function savearchivemsg(id, sociotype, messageId, profileId) {

//    try {

//        debugger;

//        var imgurl = document.getElementById('formprofileurl_' + id).src;
//        var username = document.getElementById('rowname_' + id).innerHTML;
//        var message = document.getElementById('messagedescription_' + id).innerHTML;
//        var sindex = message.indexOf('<p>');
//        var eindex = message.indexOf('</p>');
//        var msg = message.substring(sindex + 3, eindex);
//        var network = sociotype;
//        var datetime = document.getElementById('createdtime_' + id).innerHTML;
//        var totaldata = "{ 'Msg':'" + msg + "' }";
//        //alert(totaldata);
//        var jstring = "{Network:'" + network + "',CreatedTime:'" + datetime + "',UserName:'" + username + "'}";
//        $.ajax({
//            type: "POST",
//            //url: "../Message/AjaxMessage.aspx?op=savearchivemsg&imgurl=" + imgurl + "&Network=" + network + "&CreatedTime=" + datetime + "&ProfileId=" + profileId + "&MessageId=" + messageId + "&Msg=" + msg,
//            url: "../Message/AjaxMessage.aspx?op=savearchivemsg&imgurl=" + imgurl + "&Network=" + network + "&CreatedTime=" + datetime + "&ProfileId=" + profileId + "&MessageId=" + messageId + "&Username=" + username,
//            //data: jstring,
//            data: totaldata,
//            contentType: "application/json; charset=utf-8",
//            dataType: "html",
//            success: function (msg) {
//                alertify.success(msg);
//                //                $("#accountsins").html(msg);

//            }
//        });

//    } catch (e) {

//    }


//}

//function replyfunction(id, profiletype, messageid, userid) {

//    debugger;
//    try {
//        $.session('mess_id', id + ',' + profiletype + ',' + messageid + ',' + userid);
//        if (id != $.session('mess_id')) {
//            $.session('mess_id', id + ',' + profiletype + ',' + messageid + ',' + userid);
//        }
//        // document.getElementById('replytext').value = '';
//        try {
//            var messageid = document.getElementById("messageid_" + id).innerHTML;

//        } catch (e) {

//        }

//        try {
//            var name = document.getElementById("rowname_" + id).innerHTML;

//        } catch (e) {

//        }

//        try {
//            var messagedescription = document.getElementById("messagedescription_" + id).innerHTML;

//        } catch (e) {

//        }

//        try {
//            var msg = document.getElementById('messagetaskable' + id).innerHTML;

//        } catch (e) {

//        }

//        if (messagedescription.indexOf("Contents/img/pin") != -1) {
//            messagedescription = messagedescription.replace("../Contents/img/pin.png", "");
//        }
//        if (messagedescription.indexOf("Contents/img/admin/goto.png") != -1) {
//            messagedescription = messagedescription.replace("../Contents/img/admin/goto.png", "");
//        }
//        if (messagedescription.indexOf("Contents/img/archive") != -1) {
//            messagedescription = messagedescription.replace("../Contents/img/archive.png", "");
//        }

//        $("#replyMessages").html = "";
//        $("#replyMessages").html(messagedescription);

//        try {
//            var msgid = document.getElementById('messageid_' + id).innerHTML;
//            var network = document.getElementById('network_' + id).innerHTML;
//        }
//        catch (e) {
//        }


//        try {
//            var userid = document.getElementById('rowid_' + id).innerHTML;



//        } catch (e) {

//        }


//        //        $.ajax
//        //            ({
//        //                type: "POST",
//        //                url: "../Messages/AjaxMessage.aspx?op=getFacebookComments&postid=" + msgid,
//        //                data: '',
//        //                contentType: "application/json; charset=utf-8",
//        //                dataType: "html",
//        //                success: function (msg) {
//        //                    // $("#inbox_msgs").html(msg);
//        //                }
//        //            });



//        $('#replysection').bPopup({
//            fadeSpeed: 'slow',
//            followSpeed: 1500,
//            modalColor: 'black'
//        });

//        if (network == 'facebook') {
//            try {

//                $.ajax
//                         ({
//                             type: "POST",
//                             url: "../Messages/AjaxMessage.aspx?op=getFacebookComments&postid=" + msgid + "&userid=" + userid,
//                             data: '',
//                             contentType: "application/json; charset=utf-8",
//                             dataType: "html",
//                             success: function (msg) {
//                                 debugger;
//                                 if (msg == '') {
//                                     $("#replycomments").html('No Comments are available');
//                                 } else {
//                                     $("#replycomments").html(msg);
//                                 }
//                             },
//                             error: function (ee)
//                             { }
//                         });

//            } catch (e) {

//            }
//        } else if (network == 'twitter') {

//            $("#replycomments").html('No Comments are available');
//        }

//    } catch (e) {

//    }

//}

function twittercomments() {
    debugger;
    var replytext = document.getElementById('Textarea1').value.trim();
    if (replytext == "") {
        alert("Please write comment then click save!")
        return false;
    }
    var commentvl = $.session('mess_id').split(',');
    var mess_id = commentvl[0];
    var replyid = commentvl[2];
    var userid = commentvl[3];
    var username = document.getElementById('rowname_' + mess_id).innerHTML;
    var network = commentvl[1];

    //   var rowid = document.getElementById('rowid_' + mess_id).innerHTML;
    //   $.ajax
    //            ({
    //                type: "POST",
    //                url: "https://api.twitter.com/1/statuses/update.json",
    //                data: { in_reply_to_status_id: replyid, status: replytext ,screen_name='yashwant05'},
    //                crossDomain: true,
    //                contentType: "application/json; charset=utf-8",
    //                dataType: "jsonp",
    //                success: function (msg) 
    //                {
    //                    debugger;
    //                },
    //                error: function (e)
    //                {
    //                    alert(e);
    //                }
    //            });

    if (network == 'twitter') {
        $.ajax
            ({
                type: "POST",
                url: "../Message/AjaxMessage.aspx?op=twittercomments&messid=" + mess_id + "&replytext=" + replytext + "&replyid=" + replyid + "&userid=" + userid + "&username=" + username,
                data: '',
                contentType: "application/json; charset=utf-8",
                dataType: "html",
                success: function (msg) {
                    document.getElementById('Textarea1').value = '';
                    //document.getElementById('Textarea1').value = 'Commented successfully';
                    alertify.success('Commented successfully');
                    //closeonCompose();
                    $('#Span3').click();

                }
            });
    } else if (network == 'facebook') {

        $.ajax
                ({
                    type: "POST",
                    url: "../Message/AjaxMessage.aspx?op=createfacebookcomments&messid=" + mess_id + "&replytext=" + replytext + "&replyid=" + replyid + "&userid=" + userid + "&username=" + username,
                    data: '',
                    contentType: "application/json; charset=utf-8",
                    dataType: "html",
                    success: function (msg) {
                        //document.getElementById('Textarea1').value = 'Commented successfully';
                        document.getElementById('Textarea1').value = '';
                        // alert('Commented successfully');
                        alertify.success('Commented successfully');
                        $('#Span3').click();
                        //$("#replysection").hide();
                        //$(".__b-popup1__").hide();
                        //closeonCompose();
                        $.ajax
                             ({
                                 type: "POST",
                                 url: "../Message/AjaxMessage.aspx?op=getFacebookComments&postid=" + replyid + "&userid=" + userid,
                                 data: '',
                                 contentType: "application/json; charset=utf-8",
                                 dataType: "html",
                                 success: function (msg) {
                                     debugger;
                                     if (msg == '') {
                                         $("#replycomments").html('No Comments are available');
                                     } else {
                                         $("#replycomments").html(msg);
                                     }
                                 },
                                 error: function (ee)
                                 { }
                             });
                    },
                    error: function (ee) {
                        console.log(ee);
                    }
                });




    }


}


function UpdateReadStatus() {

    $.ajax
        ({
            type: "POST",
            url: "../Message/AjaxMessage.aspx?op=updatedstatus",
            data: '',
            contentType: "application/json; charset=utf-8",
            dataType: "html",
            success: function (msg) {

            }
        });

}


function BindInboxMessageonMessageTab() {
    debugger;


    try { 
        $("#sent_messages").addClass('active');

    } catch (e) {

    }
    try {
        $("#task_href").removeClass('active');
    } catch (e) {

    }
    try {
        $("#smart_inbox").removeClass('active');
    } catch (e) {

    }

    try {
        $("#archive_message").removeClass('active');
    } catch (e) {

    }
    $(".right-sidebar1").hide();


    // $("#inbox_msgs").html('<img src="../Contents/img/328.gif" alt="" height="50" width="50" style="margin-left: 350px;" />');

    $("#home_loader").show();
    try {
        $.ajax
        ({
            type: "POST",
            //url: "../Message/AjaxMessage.aspx?op=inbox_messages",
            url: "../Message/AjaxMessage.aspx?op=sentmsg",
            data: '',
            contentType: "application/json; charset=utf-8",
            dataType: "html",
            success: function (msg) {
                $("#inbox_msgs").html(msg);
                // $("#home_loader").hide();
                $(".loaderwrapper").css("display", "none");
            }
        });
    } catch (e) {
        debugger;

    }
}


function BindProfilesInMessageTab() {
    bindprofilesajax = $.ajax
        ({
            type: "POST",
            url: "../Message/AjaxMessage.aspx?op=bindProfiles",
            data: '',
            contentType: "application/json; charset=utf-8",
            dataType: "html",
            success: function (msg) {
                $("#accordianprofiles").html(msg);

            }
        });
}




function chkProfilemessage(id) {
    try {
        debugger;


        if (document.getElementById(id).src.indexOf('uncheck_click') != -1) {
            document.getElementById(id).src = "../Contents/img/check_click.png";
        } else {
            document.getElementById(id).src = "../Contents/img/uncheck_click.png";
        }

        $('#accordianprofiles ul li').each(function (i) {
            debugger;

            var inputElement = $(this).children().children().children();
            
            var attrId = inputElement.attr("id");

            if (inputElement[0].checked == false) {

                var index = arrid.indexOf(attrId);
                if (index > -1) {
                    arrid.splice(index, 1);
                }

            } else {

                var index = arrid.indexOf(attrId);
                if (index == -1) {
                    arrid.push(attrId);
                }
            }

        });


    } catch (e) {

    }


    //$.ajax
    //    ({
    //        type: "POST",
    //        url: "../Message/AjaxMessage.aspx?op=bindMessages&profileid[]=" + arrid + "&type=checked",
    //        data: '',
    //        contentType: "application/json; charset=utf-8",
    //        dataType: "html",
    //        success: function (msg) {
    //            // $("#accordianprofiles").html(msg);
    //            //  $(document).on('scroll', onScroll);
    //            $("#inbox_msgs").html(msg);
    //            $(".loaderwrapper").css("display", "none");
    //        }
    //    });

    $.ajax
        ({
            type: "GET",
            url: "../Messages/LoadMessagesByProfile?op=bindMessages&profileid[]=" + arrid + "&type=checked",
            data: '',
            contentType: "application/json; charset=utf-8",
            dataType: "html",
            success: function (msg) {
                //// $("#accordianprofiles").html(msg);
                ////  $(document).on('scroll', onScroll);
                //$("#inbox_msgs").html(msg);
                //$(".loaderwrapper").css("display", "none");
                if (msg.indexOf("nodata") > -1) {
                    //No data Found...!!
                    $("#divBindMessage").html(msg);
                }
                else {
                    //$("#divBindMessage").append(msg);
                    $("#divBindMessage").html(msg);
                    $(".loaderwrapper").css("display", "none");
                }
            }
        });

}

function hideTask(divId) {
    $("#" + divId).hide(900);
}

function getlocatdatetime() {
    var curdate = new Date();
    var dd = curdate.getDate();
    if (dd < 10) {
        dd = '0' + dd
    }
    else {
        dd = curdate.getDate();
    }
    var mm = curdate.getMonth() + 1;
    if (mm < 10) {
        mm = '0' + mm
    }
    else {
        mm = curdate.getMonth() + 1;
    }
    var hh = curdate.getHours();
    if (hh < 10) {
        hh = '0' + hh;
    }
    else {
        hh = curdate.getHours();
    }
    var minm = curdate.getMinutes();
    if (minm < 10) {
        minm = '0' + minm;
    }
    else {
        minm = curdate.getMinutes();
    }
    var sec = curdate.getSeconds();
    if (sec < 10) {
        sec = '0' + sec;
    }
    else {
        sec = curdate.getSeconds();
    }
    return now = curdate.getFullYear() + "/" + mm + "/" + dd + " " + hh + ":" + minm + ":" + sec;
}



function bindInboxMessages()
{
    debugger;
    $.ajax({
        type: "GET",
        url: "../Messages/BindUserProfileByGroup",
        datatype: "html",
        success: function (msg) {

            $("#div-user-profiles").html(msg);
        }
    });

    $.ajax({
        type: "GET",
        url: "../Messages/BindUserMessageType",
        datatype: "html",
        success: function (msg) {

            $("#div-user-message").html(msg);
        }
    });

    $.ajax({
        type: "GET",
        url: "../Messages/BindInboxMessage?load=first",
        datatype: "html",
        success: function (msg) {
            if (msg == "no_data") {
                $("#ul-inbox-message").html("<div><center><h3>No Messages Found.</h3></center></div>");
            }
            else {
                $("#ul-inbox-message").html(msg);
            }
        }
    });

}

function filterinboxmessages(id) {
    debugger;
    arrid = new Array();
    arrmsgtype = new Array();
    try {
        $("#div-user-message .cls-user-message").each(function () {
            debugger;
            var attrId = $($($(this).children()[2]).children()[0]).attr("id");
            if (document.getElementById(attrId).checked == false) {
                var index = arrmsgtype.indexOf(attrId);
                if (index > -1) {
                    arrmsgtype.splice(index, 1);
                }
            } else {
                arrmsgtype.push(attrId);
            }
        });
    } catch (e) {

    }
    debugger;
    try {
        $("#div-user-profiles .cls-user-profile").each(function () {
            debugger;
            var attrId = $($($(this).children()[2]).children()[0]).attr("id");
            if (document.getElementById(attrId).checked == false) {
                var index = arrmsgtype.indexOf(attrId);
                if (index > -1) {
                    arrid.splice(index, 1);
                }
            } else {
                arrid.push(attrId);
            }
        });
    } catch (e) {

    }

    $.ajax({
        type: "GET",
        url: "../Messages/BindInboxMessage?load=filter&arrmsgtype=" + arrmsgtype + "&arrid=" + arrid,
        datatype: "html",
        success: function (msg) {
            if (msg == "no_data") {
                $("#ul-inbox-message").html("<div><center><h3>No Messages Found.</h3></center></div>");
            }
            else {
                $("#ul-inbox-message").html(msg);
            }
        },
        async: false
    });
}

function bindInboxChatMessages() {
    debugger;
    $.ajax({
        type: "GET",
        url: "../Messages/BindUserProfileByGroupChat",
        datatype: "html",
        success: function (msg) {

            $("#div-user-profiles").html(msg);
        }
    });
     

    $.ajax({
        type: "GET",
        url: "../Messages/BindInboxChatMessage?load=first",
        datatype: "html",
        success: function (msg) {
            if (msg == "no_data") {
                $("#ul-inbox-chat").html("<div><center><h3>No Messages Found.</h3></center></div>");
            }
            else {
                $("#ul-inbox-chat").html(msg);
            }
        }
    });

}
function filterinboxchatmessages(id)
{
    debugger;
    arrid = new Array();
    try {
        $("#div-user-profiles .cls-user-profile").each(function () {
            debugger;
            var attrId = $($($(this).children()[2]).children()[0]).attr("id");
            if (document.getElementById(attrId).checked == false) {
                var index = arrmsgtype.indexOf(attrId);
                if (index > -1) {
                    arrid.splice(index, 1);
                }
            } else {
                arrid.push(attrId);
            }
        });
    } catch (e) {

    }

    $.ajax({
        type: "GET",
        url: "../Messages/BindInboxChatMessage?load=filter&&arrid=" + arrid,
        datatype: "html",
        success: function (msg) {
            if (msg == "no_data") {
                $("#ul-inbox-chat").html("<div><center><h3>No Messages Found.</h3></center></div>");
            }
            else {
                $("#ul-inbox-chat").html(msg);
            }
        },
        async: false
    });
}


function MailPopUpMsg(msgid) {
    debugger;
    $.ajax({
        type: 'POST',
        url: '../Messages/ShowInboxMsgMailPopUp?MsgId=' + msgid,
        dataType: "html",
        success: function (data) {
            $('#msgmailpopup').html(data);
            $("#msgmailpopup").modal('show');
        }
    });
}

function opentask(msgdesc, msgdate) {
    debugger;
    var msgTxt = $('#' + msgdesc).text();
    $('#savetask').attr('msgdesc', msgTxt);
    $('#savetask').attr('msgdate', msgdate);
}

function opnchatmsg(SenderId, RecipientId) {

    $.ajax({
        type:"POST",
        url: "../Messages/ShowChat?SenderId=" + SenderId + "&RecipientId=" + RecipientId,
        dataType: "html",
        success: function (msg) {
            $("#chat-conversation").html(msg);
        }

    });

}