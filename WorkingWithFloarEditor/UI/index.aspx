<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WorkingWithFloarEditor.index" ValidateRequest="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/font-awesome.css" rel="stylesheet" /> 
    
    <link href="../froala_editor_1.2.7/css/froala_editor.css" rel="stylesheet" />
    <link href="../froala_editor_1.2.7/css/froala_style.css" rel="stylesheet" />

 
    

</head>
<body> 
    <form id="form1" runat="server">  
    <div>
    <textarea id="edit" runat="server"></textarea>
        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />

    </div>
    </form>
    <script src="../Scripts/jquery-2.1.4.js"></script>
    <script src="../froala_editor_1.2.7/js/froala_editor.min.js"></script>
    

    <script src="../froala_editor_1.2.7/js/plugins/block_styles.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/colors.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/font_family.min.js"></script>
    
    <script src="../froala_editor_1.2.7/js/plugins/font_size.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/lists.min.js"></script>
    
    <script src="../froala_editor_1.2.7/js/plugins/video.min.js"></script>

    <script>
      $(function() {
          $('#edit').editable({ inlineMode: false, alwaysBlank: true })
      });
  </script>


</body>

</html>
