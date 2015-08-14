<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WatchVideo.aspx.cs" Inherits="VideoPlay.WatchVideo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>EJU视频会议直播</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <link rel="apple-touch-icon" href="favicon.ico" />
    <link rel="icon" type="image/vnd.microsoft.icon" href="favicon.ico">
    <link rel="icon" type="image/png" href="favicon.png">
    <link href="css/meeting.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/jquery-1.4.2.min.js"></script>
    <link href="CSS/screen.css" rel="stylesheet" type="text/css" />
    <script type='text/javascript' src='jwplayer.js'></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $(".video_list").find("li").each(function (i) { if (!(i % 2)) $(this).addClass("on") })
            var date = new Date();
            var year = date.getFullYear();
            var month = date.getMonth() + 1;
            var day = date.getDate();
            time = "会议时间：" + year + "-" + month + "-" + day;
            document.getElementById("time").innerText = time;
        });

    </script>
</head>
<body>
    <div class="logo">
    </div>
    <form action="/" runat="server" method="post">
    <div class="main">
        <div class="main_t">
            <div class="left_tit">
                视频会议回顾
            </div>
            <div class="right_tit">
                <span class="play_now">正在播放</span>
            
              
                <span class="return" runat="server" id="returnbk" ><asp:Literal ID="litreturnzhibo" runat="server"></asp:Literal></span>
                
            </div>
        </div>
        <div class="main_mid">
            <div class="main_body">
                <div class="video_list">
                    <asp:TextBox ID="page_hide" runat="server" Style="display: none;"></asp:TextBox>
                    <ul style="height: 390px;">
                        <asp:Repeater ID="video_rpt" runat="server" OnItemDataBound="Video_ItemDataBound">
                            <ItemTemplate>
                                <li>
                                    <table width="100%" cellpadding="0" cellspacing="0">
                                        <tr>
                                            <td>
                                                <span class="pic"><a href="WatchVideo.aspx?id=<%#Eval("Id")%>&usercode=<%=usercode %>">
                                                    <img alt="" src="image/<%#Eval("VideoImg") %>" style="display: block; border: 0px;"
                                                        width="72" height="46" />
                                                </a></span>
                                            </td>
                                            <td>
                                                <a href="WatchVideo.aspx?id=<%#Eval("Id")%>"><i>
                                                    <%# VideoPlay.TransForm.ToString(Eval("VideoTitle"),10) %></i></a> <em>
                                                        <%# FormatDate(Eval("VideoTime").ToString())%>
                                                    </em>
                                            </td>
                                        </tr>
                                    </table>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                        <asp:Literal ID="litMsg" runat="server"></asp:Literal>
                    </ul>
                    <div>
                        <div class="pagination-wrap right">
                            <asp:Literal ID="page_str" runat="server"></asp:Literal>
                        </div>
                    </div>
                </div>
                <div class="video_play">
                    <div class="video">
                        <div id='mediaspace'>
                            This text will be replaced</div>
                        <script type='text/javascript'>
				    //播放器
                    <%=sb %>

//		
                        </script>
                    </div>
                    <div class="sep">
                    </div>
                    <div class="video_info">
                        <div class="meeting_time">
                            <asp:Label Text="" runat="server" ID="meet_time" /></div>
                        <div class="meeting_topic">
                            <asp:Label ID="meet_top" Text="" runat="server" /></div>
                    </div>
                </div>
            </div>
            <div class="clr">
            </div>
        </div>
        <div class="main_b">
        </div>
    </div>
    </form>
    <script>


        //-----------分页-----------
        function videopage(v) {
            $('#page_hide').val(v);
            Search();
            return false;
        }
        function Search(v) {
            if (v) $('#page_hide').val(v);
            var page = $('#page_hide').val();
            window.location = "?usercode=<%=usercode %>&p=" + page;
            return false;
        }

        function PlayVideo(url, time, title) {
          //  alert(url);
            window.location = "WatchVideo.aspx?url=" + url;
            //          $.ajax({
            //              url: "Handler1.ashx",
            //              dataType: "json",
            //              data: { "id": id },
            //              type: "post",
            //              success: function (da) {
            //                  $("#meet_time").html("会议时间：" + da[0].meettime);
            //                  $("#meet_top").html("会议主题：" + da[0].title);


            //              }

            //          })


        }
        //回到直播
       // function backLive() {
           // window.location = "WatchVideo.aspx";
                             
//                  $.ajax({
//                      url: "ReturnBack.aspx",
//                      data: {},
//                      type: "post",
//                      success: function (da) {
//                          alert(da);
//                      }
//                  });
             // }

    </script>
</body>
</html>
