<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddVideo.aspx.cs" Inherits="VideoPlay.AddVideo" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.2.min.js" type="text/javascript"></script>
    <script src="js/jquery-ui-1.10.3.custom.min.js" type="text/javascript"></script>
    <link href="CSS/jquery-ui-1.10.3.custom.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="My97DatePicker/WdatePicker.js"></script>
    <title></title>
<%--    <script>
        $(function () {
      
            $("#meetTime").datepicker({
                dateFormat: "yy-mm-dd",
                changeMonth: true,
                changeYear: true

            });

          });
    </script>--%>
       <style>
        #foot
        {
            background-image:url('image/bj3.jpg');
            height:35px;
            line-height:35px;
            font-size:12px;
            font-family:黑体;
            }
    </style>
</head>
<body>
<div style="background-image:url('image/findallvideo.jpg'); background-repeat:no-repeat; height:700px; width:1024px; margin-left:200px;">
 <form id="form1" runat="server" action="SaveAddVideoInfo.aspx">
<div style="width:80%;margin-left: auto;margin-right: auto;">

<h4 style=" padding-top:80px;color:#323232;font-size:20px;border-bottom:1px dashed #D4D4D4">视频上传</span></h4>


    <input type="hidden" id="meetId" name="meetId" value="<%# vi.Id %>" />
    <div style="height:10px;"></div>

    <table style="width:100%;"cellspacing="14" cellpadding="0">
    <tr>
    <td style="width:30%"><span style="font-size:15px;color:#323232;font-family:黑体;float:right;">&nbsp;会议主题：</span><span style="color:Red;float:right;">*</span></td>
    <td style="width:70%"><input type="text" id="meetTitle" name="meetTitle" style="width:430px;height:20px;float:left;"  /></td>
    </tr>
     <tr>
    <td style="width:30%"><span style="font-size:15px;color:#323232;font-family:黑体;float:right;">&nbsp;视频链接：</span><span style="color:Red;float:right;">*</span></td>
    <td style="width:70%"><input type="text" id="meetUrl" name="meetUrl" style="width:430px;height:20px;float:left;"  /></td>
    </tr>
     <tr>
    <td style="width:30%"><span style="font-size:15px;color:#323232;font-family:黑体;float:right;">&nbsp;会议时长：</span><span style="color:Red;float:right;">*</span></td>
    <td style="width:70%"><input type="text" id="meetLongTime" name="meetLongTime" style="width:430px;height:20px;float:left;"/></td>
    </tr>
    <tr>
    <td style="width:30%"><span style="font-size:15px;color:#323232;font-family:黑体;float:right;">&nbsp;会议日期：</span><span style="color:Red;float:right;">*</span></td>
    <td style="width:70%"><input type="text" id="meetTime" name="meetTime" onfocus="WdatePicker({dateFmt:'yyyy-MM-dd HH:mm'})" style="width:430px;height:20px;float:left;"/></td>
    </tr>
     <tr>
    <td style="width:30%"><span style="font-size:15px;color:#323232;font-family:黑体;float:right;">&nbsp;会议图像：</span><span style="color:Red;float:right;">*</span></td>
    <td style="width:70%"><asp:FileUpload ID="FileUpload1" runat="server" style="float:left;"/></td>
    </tr>
     <tr>
    <td style="width:30%"><span style="font-size:15px;color:#323232;font-family:黑体;float:right;">&nbsp;会议简介：</span></td>
    <td style="width:70%"><textarea rows="5" cols="28" id="meetMemo" name="meetMemo" style="width:430px;float:left;"></textarea></td>
    </tr>
    </table>
    <table style="width:100%">
    <tr>
    <td style="width:50%"> 
    <input type="submit" value="" style=" background-image:url('image/btn_save.jpg');float:right; width:88px; height:33px;border:0px;cursor:pointer" id="btnSave"   />
   <%-- <asp:ImageButton ID="btnSave" ImageUrl="image/btn_save.jpg"   runat="server" OnClick="btnSave_Click"  />--%></td>
    <td style="width:50%">
    <img alt="" src="image/btn_res.jpg"  type="button" style="cursor:pointer" id="esc" onclick="javascript:window.location.replace(location.href+'');" /></td>
    </tr>
    </table>
<%--    <p style="padding-right:150px;"><span style=" color:Red;">*</span><span style="font-size:15px;color:#323232;font-family:宋体">&nbsp;会议主题：</span><input type="text" id="meetTitle" name="meetTitle" size="34"  required /></p>
    <p><span style=" color:Red;">*</span>&nbsp;视频链接：<input type="text" id="meetUrl" name="meetUrl" size="34"  required/></p>
    <p><span style=" color:Red;">*</span>&nbsp;会议时长：<input type="text" id="meetLongTime" name="meetLongTime" size="34"  required/></p>
    <p><span style=" color:Red;">*</span>&nbsp;会议日期：<input type="text" id="meetTime" name="meetTime" size="34"  readonly required/></p>
    <p><span style=" color:Red;">*</span>&nbsp;会议图像：<asp:FileUpload ID="FileUpload1" runat="server" onchange="CheckImgCss(this, 'img',this.value);"  required />
        <%--<img src="image/<" height="100"; width="100" id="imgs" />--%><%--</p>
    <p> 会议简介：<textarea rows="5" cols="28" id="meetMemo" name="meetMemo"></textarea></p>--%>
    <%--<p><input type="submit" value="保存" />&nbsp;<input type="button" id="esc" value="取消" /></p>--%>
    <br /><br />
      <div id="foot">2014易居(中国)控股有限公司 All Rights Reserved  </div>
    </div>
    </form>
</div>
  <script>

      $("#btnSave").click(function () {
          if ($("#meetTitle").val() == "") {
              alert("会议主题不能为空");
              return false;
          } else if ($("#meetUrl").val() == "") {
              alert("视频链接不能为空");
              return false;
          } else if ($("#meetLongTime").val() == "") {
              alert("会议时长不能为空");
              return false;
          } else if ($("#meetTime").val() == "") {
              alert("会议日期不能为空");
              return false;
          }

      })


      function CheckImgCss(o, img, value) {

          if (!/\.((jpg)|(bmp)|(gif)|(png))$/ig.test(o.value)) {
              alert('只能上传jpg,bmp,gif,png格式图片!');
              o.outerHTML = o.outerHTML;
          }
          else {
              $(img).filters.item("DXImageTransform.Microsoft.AlphaImageLoader").src = o.value;
           


          }
      }
      $("#esc").click(function () {
          window.location = "ShowAllVideo.aspx";

      })
  </script>
   
</body>
</html>
