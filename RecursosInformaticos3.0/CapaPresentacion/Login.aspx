<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CapaPresentacion.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>AdminLTE 2 | Log in</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport"/>
    <!-- Bootstrap 3.3.7 -->
    <link rel="stylesheet" href="AdminLTE-2.4.0/bower_components/bootstrap/dist/css/bootstrap.min.css"/>
    <!-- Font Awesome -->
    <link rel="stylesheet" href="AdminLTE-2.4.0/bower_components/font-awesome/css/font-awesome.min.css"/>
     <!-- Ionicons -->
     <link rel="stylesheet" href="AdminLTE-2.4.0/bower_components/Ionicons/css/ionicons.min.css"/>
    <!-- Theme style -->
    <link rel="stylesheet" href="AdminLTE-2.4.0/dist/css/AdminLTE.min.css"/>
     <!-- iCheck -->
    <link rel="stylesheet" href="AdminLTE-2.4.0/plugins/iCheck/square/blue.css"/>
    <!-- Google Font -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic"/>

</head>
<body class="hold-transition login-page">
    <div class="login-box">
        <div class="login-logo">
            <a>Farias <b>Recursos TI</b></a>
        </div>
        <!-- /.login-logo -->
        <div class="login-box-body">
            <p class="login-box-msg">Iniciar sesión</p>
            <form id="form1" runat="server">
                <div class="form-group has-feedback">
                    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login_Authenticate" EnableViewState="false" Width="100%">
                        <LayoutTemplate>
                            <div class="form-group has-feedback">
                                <asp:TextBox ID="UserName" runat="server" class="form-control" placeholder="Email"></asp:TextBox>
                                <span class="glyphicon glyphicon-user form-control-feedback"></span>
                            </div>
                            <div class="form-group has-feedback">
                                <asp:TextBox ID="Password" runat="server" type="password" class="form-control" placeholder="Password"></asp:TextBox>
                                <span class="glyphicon glyphicon-lock form-control-feedback"></span>
                            </div>
                            <div class="row">
                                <div class="col-xs-8">
                                    <div class="checkbox icheck">
                                        <label>
                                            <input type="checkbox"  class="auto-style1"/>
                                            Recuérdame
                                        </label>
                                    </div>
                                </div>
                                <!-- /.col -->
                                <div class="col-xs-4">
                                    <asp:Button ID="btnIngresar" CommandName="Login" runat="server" Text="Ingresar" class="btn btn-primary btn-block btn-flat" />
                                </div>
                                <!-- /.col -->
                            </div>
                        </LayoutTemplate>
                    </asp:Login>                    
                </div>
            </form>
        </div>
        <!-- /.login-box-body -->
    </div>
<!-- /.login-box -->
<!-- jQuery 3 -->
<script src="AdminLTE-2.4.0/bower_components/jquery/dist/jquery.min.js"></script>
<!-- Bootstrap 3.3.7 -->
<script src="AdminLTE-2.4.0/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
<!-- iCheck -->
<script src="AdminLTE-2.4.0/plugins/iCheck/icheck.min.js"></script>
    <script>
  $(function () {
    $('input').iCheck({
      checkboxClass: 'icheckbox_square-blue',
      radioClass: 'iradio_square-blue',
      increaseArea: '20%' /* optional */
    });
  });
</script>
</body>
</html>

