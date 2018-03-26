<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="jquery-3.3.1.min.js"></script>
   <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {

            $.ajax({

                url: 'EmployeeService1.asmx/spGetEmployees',
                method: 'post',
                dataType: 'json',
                success: function (data) {
                    $('#datatable').dataTable({

                        data: data,
                        searching:true,
                        columns: [

                            { 'data': 'Id' },
                            { 'data': 'FName' },
                            { 'data': 'LName' },
                            { 'data': 'Age' },
                        ]
                    });
                }

            });

        });

        </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="border:1px solid black; padding:3px; width:500px;  ">
        <table id ="dataTable">
            <thead>
                 <tr>
                        <th>Id &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>
                        <th>First Name &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>
                        <th>Last Name &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>
                        <th>Age &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>
                 </tr>
                </thead>
        </table>
    
    </div>
    </form>
</body>
</html>
