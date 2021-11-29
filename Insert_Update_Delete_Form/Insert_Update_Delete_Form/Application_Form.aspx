<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Application_Form.aspx.cs" Inherits="Insert_Update_Delete_Form.Application_Form" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Student Registration</title>
    <style type="text/css">
        .style1
        {
            width: 130px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
    <tital>Student Registration</title>
    <table>
    <tr>
    
    <td class="td">ID:</td>  
            <td>  
                <asp:TextBox ID="txtID" runat="server" Width="200px"></asp:TextBox></td>
                
                
            <td class="style1">
    </tr>
    <tr>  
            <td class="td">Name:</td>  
            <td>  
                <asp:TextBox ID="txtName" runat="server" Width="201px"></asp:TextBox></td>  
            <td class="style1">   
        </tr>
        <tr>  
            <td class="td">Address:</td>  
            <td>  
                <asp:TextBox ID="txtAddress" runat="server" Width="200px"></asp:TextBox></td>  
            <td class="style1"> </td>  
        </tr>
        <tr>  
            <td class="td">Mobile:</td>  
            <td>  
                <asp:TextBox ID="txtMobile" runat="server" Width="201px"></asp:TextBox></td>  
            <td class="style1"> </td>  
        </tr>
        <tr>  
            <td class="td">Email ID:</td>  
            <td>  
                <asp:TextBox ID="txtEmail" runat="server" Width="199px"></asp:TextBox></td>  
            <td class="style1"> </td>  
        </tr>
        <tr>  
            <td></td>  
            <td>  
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /> 
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" /> 
              </td> 
            <td class="style1"></td>  
        </tr>
        </table>
        <div>
        </center>
        </div>
    </div>
    </form>
</body>
</html>
