<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAllVideo.aspx.cs" Inherits="VideoPlay.ShowAllVideo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="CSS/screen.css" rel="stylesheet" type="text/css" />
    <script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.2.min.js" type="text/javascript"></script>
    <style type="text/css">
        *
        {
            margin: 0;
            padding: 0;
        }
        body
        {
            margin-top: 10px;
            margin-right: auto;
            margin-bottom: 10px;
            margin-left: auto;
            text-align: center;
            height: auto;
            width: auto;
            font-size: 14px;
            font-family: 黑体;
            list-style:none;
            list-style-type:none;
            
        }
        ul,li
        {
            margin:0px; padding:0px; list-style:none;
            list-style-type:none;
        }
        #top
        {
            width: 739px;
            height: 65px;
            background: #D6D3CE url(top.gif) no-repeat;
        }
        #bottom
        {
            width: 739px;
            height: 45px;
            background: #D6D3CE url(bottom.gif) no-repeat 615px 0px;
            font-size: 12px;
            font-weight: normal;
            text-align: left;
            padding: 22px 0 0 22px;
        }
        #container
        {
            text-align: left;
            width: 1000px;
            margin: 0 11px;
            padding-top: 100px;
        }
        
        #conleft
        {
            float: left;
            width: 134px;
            height: 296px;
            border: 1px #7B9EBC solid;
            background: #FFF;
            text-align: center;
            padding-top: 10px;
        }
        #conright
        {
            float: right;
            width: 550px;
            height: 306px;
            border: 1px #7B9EBC solid;
            background: #FFF;
        }
        #container #title
        {
            height: 28px;
        }
        #container #title li
        {
            float: left;
            list-style-type: none;
            height: 28px;
            line-height: 28px;
            text-align: center;
            margin-right: 1px;
        }
        #container #content ul
        {
            margin: 10px;
        }
        #container #content li
        {
            margin: 5px;
        }
        #container #content li img
        {
            margin: 5px;
            display: block;
        }
        #container #content
        {
            clear:both;
            height: 500px;
           
            padding: 10px;
        }
         #container #content table
         {
              border:1px solid #cccccc;
              width:1000px;
              margin-left:-10px;
             }
    
        
   
        .hidecontent
        {
            display: none;
        }
        /*-----------Tags-----------*/
        #container #title a
        {
            text-decoration: none;
            color: #000000;
            display: block;
            width: auto;
            background: url(tagleft.gif) no-repeat left -29px;
        }
        #container #title a span
        {
            display: block;
            background: url(tagright.gif) no-repeat right -29px;
            padding: 0 25px 0 25px;
        }
        
        #container #title #tag1
        {
            border: solid 1px #cccccc;
            
        }
    
            
        
        #container #title #tag2
        {
            border: solid 1px #cccccc;
       
        }
        
        #container #title #tag1 a:hover
        {
            text-decoration: none;
            color: Gray;
            display: block;
            width: auto;
            background: url(tagleft.gif) no-repeat left -87px;
             border-bottom: 0px;
        }
        #container #title #tag1 a:hover span
        {
            display: block;
            background: url(tagright.gif) no-repeat right -87px;
            padding: 0 25px 0 25px;
             border-bottom: 0px;
        }
        
        #container #title #tag2 a:hover
        {
            
            text-decoration: none;
            color: Gray;
            display: block;
            width: auto;
            background: url(tagleft.gif) no-repeat left -58px;
            border-bottom: 0px;
        }
        #container #title #tag2 a:hover span
        {
            display: block;
            background: url(tagright.gif) no-repeat right -58px;
            padding: 0 25px 0 25px;
          
            
        }
        #container #title .selectli1
        {
            text-decoration: none;
            color: Gray;
            display: block;
            width: auto;
            background: url(tagleft.gif) no-repeat left -87px;
        }
        #container #title a .selectspan1
        {
            display: block;
            background: url(tagright.gif) no-repeat right -87px;
            padding: 0 25px 0 25px;
            
        }
        
        #container #title .selectli2
        {
            text-decoration: none;
            color: Gray;
            display: block;
            width: auto;
            background: url(tagleft.gif) no-repeat left -58px;
        }
        #container #title a .selectspan2
        {
            display: block;
            background: url(tagright.gif) no-repeat right -58px;
            padding: 0 25px 0 25px;
        
        }
        
        /*----------------table中的样式-------------------------------*/
        .tr1
        {
            background-image: url("image/bck.jpg");
            background-repeat:repeat-x;
            height: 30px;
        }
        
        .style1
        {
            height: 14px;
        }
        
        .display
        {
            display: none;
        }
        tr
        {
            margin-top: 110px;
            padding-top: 110px;
        }
         .divtable 
         {
             width:1000px;
             
             }
        
        .divtable td
        {
            padding-left:10px;
           border-bottom: dotted 1px #cccccc;
        }
    
        #content2
        {
             border: solid 1px #cccccc;
             margin-left:-10px;
             height:500px;
            }
        
        
        #foot
        {
            background-image:url('image/bj3.jpg');
            height:35px;
            line-height:35px;
            font-size:12px;
            
            }
      
    </style>
    <!-------------去掉连接的虚线框----------------->
    <script>
        function bluring() {
            if (event.srcElement.tagName == "A" || event.srcElement.tagName == "IMG") document.body.focus();
        }
        document.onfocusin = bluring;
    </script>
    <!----------------标签设计--------------------->
    <script language="javascript">
        function switchTag(tag, content) {
            //  alert(tag);
            //  alert(content);
            for (i = 1; i < 3; i++) {
                if ("tag" + i == tag) {
                    document.getElementById(tag).getElementsByTagName("a")[0].className = "selectli" + i;
                    document.getElementById(tag).getElementsByTagName("a")[0].getElementsByTagName("span")[0].className = "selectspan" + i;
                } else {
                    document.getElementById("tag" + i).getElementsByTagName("a")[0].className = "";
                    document.getElementById("tag" + i).getElementsByTagName("a")[0].getElementsByTagName("span")[0].className = "";
                }
                if ("content" + i == content) {
                    document.getElementById(content).className = "";
                   
                    
                } else {
                  
                    document.getElementById("content" + i).className = "hidecontent";
                }
                document.getElementById("content").className = content;
            }
        }
    </script>
</head>
<body>
    <form id="Form1" runat="server" method="post">
    <div style="background-image: url('image/findallvideo.jpg'); background-repeat: no-repeat;
        height: 700px; width: 1024px; margin-left: 200px;">
        <asp:TextBox ID="page_hide" runat="server" CssClass="display"></asp:TextBox>
        <%--<input type="hidden" id="page" value="<asp:Literal ID="page_hide" runat="server" />" />   cellpadding="0" cellspacing="0"--%>
        <div id="container">
            <div id="title">
                <ul>
                    <li id="tag1"><a href="#" onclick="switchTag('tag1','content1');this.blur();" class="selectli1">
                        <span class="selectspan1">点播管理</span></a></li>
                    <li id="tag2"><a href="#" onclick="switchTag('tag2','content2');this.blur();"><span>
                        直播管理</span></a></li>
                    <li style=" border: solid 1px #cccccc;"><a href="AddVideo.aspx"><span>视频添加</span></a></li>
                  
                </ul>
            </div>
      
            <div id="content">
                <div id="content1">
                    <div style="height: 580px;" class="divtable">
                        <table cellpadding="0" cellspacing="0">
                            <tr class="tr1">
                                <td style="width: 100px;">
                                    视频
                                </td>
                                <td style="width: 600px;">
                                    &nbsp;
                                </td>
                                <%-- <td style=" width:200px;">
                                    状态
                                </td>--%>
                                <td style="width: 180px;">
                                    操作
                                </td>
                            </tr>
                            <asp:Repeater ID="video_rpt" runat="server" OnItemDataBound="Video_ItemDataBound">
                                <ItemTemplate>
                                    <tr style=" height:120px;">
                                        <td>
                                            <img src="image/<%#Eval("VideoImg") %>" height="100" width="100" />
                                        </td>
                                        <td>
                                            <div>
                                                <ul>
                                                    <li>
                                                        <%#Eval("VideoTitle")%></li><li>
                                                            <%# FormatDate(Eval("VideoTime").ToString())%></li></ul>
                                            </div>
                                        </td>
                                        <%--      <td rowspan="2">
                                            <%# Eval("VideoStatus").ToString()=="True"?"已发布":"未发布"%>
                                        </td>--%>
                                        <td>
                                            <input type="button" onclick="javascript:Update('<%# Eval("Id").ToString()%>')" value="编辑" />
                                            &nbsp;<input type="button" onclick="javascript:Delete('<%# Eval("Id").ToString()%>')"
                                                value="删除" />
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </table>
                    </div>
                    <div style="text-align: center;">
                        <div class="pagination-wrap right">
                            <asp:Literal ID="page_str" runat="server"></asp:Literal>
                        </div>
                    </div>
                </div>
                <div id="content2" class="hidecontent">
                <br />
                    直播路径：
                    <asp:TextBox ID="live_url_hide" runat="server" size='34'></asp:TextBox>
                    &nbsp;&nbsp;<input type="button" value="保存" id="save" name="save" style="height: 22px;" />
                </div>
                  <br /><br />
                  <div id="foot">2014易居(中国)控股有限公司 All Rights Reserved  </div>
                  <br /><br />
            </div>

          
        </div>
    </div>
    </form>
</body>
<script>
    var status = '<%= url_status %>';

    //-----------分页-----------
    function videopage(v) {
        $('#page_hide').val(v);
        Search();
        return false;
    }
    function Search(v) {
        if (v) $('#page_hide').val(v);
        var page = $('#page_hide').val();
        window.location = "?p=" + page;
        return false;
    }
    //------------编辑--------------
    function Update(id) {
        //跳页面修改
        window.location = "updateVideo.aspx?id=" + id;


    }
    //------------删除--------------
    function Delete(id) {
        //根据id进行删除
        if (confirm("你确定要删除吗？")) {
            window.location = "DeleteVideo.aspx?id=" + id;
        }


    }
    //-----------添加或修改直播路径-------------
    $("#save").click(function () {
        if (status == "insert") {

            //添加操作

            var url = $("#live_url_hide").val();
            if (url == "") {
                alert("请输入地址");
            } else {
                window.location = "AddLiveVideo.aspx?url=" + url;
            }
        } else {
            var url = $("#live_url_hide").val();
            if (url == "") {
                alert("请输入地址");
            } else {
                //修改操作
                window.location = "UpdateLiveVideo.aspx?url=" + url;
            }

        }
    })

</script>
</html>
