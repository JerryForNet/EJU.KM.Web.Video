<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="VideoPlay.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.2.min.js" type="text/javascript"></script>
    <script src="js/jquery-ui-1.10.3.custom.min.js" type="text/javascript"></script>
    <title></title>
    <style type="text/css">
      body
      {
          font-family:黑体;
          }
          
         #foot
        {
            background-image:url('image/bj3.jpg');
            height:35px;
            line-height:35px;
            font-size:12px;
          
         } 
         
         #form1
         {
             height:600px;
             
             }
    </style>
</head>
<body>
<div style=" background-image:url('image/login.jpg'); background-repeat:no-repeat; height:700px; width:1024px; margin-left:200px;">

  <form id="form1" method="post" action="check_login.aspx">
  <div style=" text-align:center; padding-top:200px; ">
  <table cellspacing="18" cellpadding="0" style="width:100%;">
  <tr>
  <td style="width:45%;"><span style="font-size:15px;color:#323232;font-family:黑体;float:right;">账&nbsp;&nbsp;号：</span><span style="color:Red;float:right;">*</span></td>
  <td style="width:55%;"><input type="text" id="username" name="username" style="float:left;" /></td>
  </tr>
  <tr>
  <td style="width:45%;"><span style="font-size:15px;color:#323232;font-family:黑体;float:right;">密&nbsp;&nbsp;码：</span><span style="color:Red;float:right;">*</span></td>
  <td style="width:55%;"><input type="password" id="password" name="pwd" style="float:left;" /></td>
  </tr>
  <tr><td colspan="2" style="align:center;"><input type="submit" id="btnLogin" value="" style=" background-image:url('image/lg.jpg'); width:103px; height:31px;border:0px;cursor:pointer;margin-right:40px;" /></td></tr>

  </table>
  </div>
<%--    <div style=" text-align:center; padding-top:200px; ">
     <p>账&nbsp;&nbsp;号：<input type="text" id="username" name="username" /></p>
     <p>密&nbsp;&nbsp;码：<input type="password" id="pwd" name="pwd" /></p>
     <p><input type="submit" value="" style=" background-image:url('image/lg.jpg'); width:103px; height:31px;border:0px;cursor:pointer" /></p>
    </div>--%>
    </form>
  <div id="foot">2014易居(中国)控股有限公司 All Rights Reserved  </div>
</div>
        <script>
          var p = <%=p %>;
          if(p=='1')
          {
           alert("账号密码输入错误");
          }
          

            $("#btnLogin").click(function () {
                if ($("#username").val() == "") {
                    alert("账号不能为空");
                    return false;
                } else if ($("#password").val() == "") {
                    alert("密码不能为空");
                    return false;
                }

            })
    </script>
   
</body>
</html>
