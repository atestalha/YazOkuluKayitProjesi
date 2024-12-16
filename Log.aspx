<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log.aspx.cs" Inherits="WebApplication1.Log" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login Page</title>
    <style>
        body {
            font-family: 'Roboto', sans-serif;
            margin: 0;
            padding: 0;
            background: url('https://binlercepresets.shop/wp-content/uploads/2023/11/cappadocia-landscape-turkey_984745-6.jpg') no-repeat center center/cover;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            color: #fff;
            overflow: hidden;
        }

        .login-container {
            background: rgba(0, 0, 0, 0.7);
            border-radius: 15px;
            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.5);
            padding: 40px 30px;
            width: 350px;
            text-align: center;
            color: #fff;
        }

            .login-container h1 {
                font-size: 28px;
                margin-bottom: 25px;
                color: #1e90ff;
            }

            .login-container input[type="text"],
            .login-container input[type="password"] {
                width: 100%;
                padding: 12px;
                margin: 10px 0;
                border: 1px solid #ddd;
                border-radius: 25px;
                font-size: 16px;
                box-sizing: border-box;
            }

            .login-container button {
                width: 100%;
                padding: 12px;
                background: #1e90ff;
                color: #fff;
                border: none;
                border-radius: 25px;
                font-size: 18px;
                font-weight: bold;
                cursor: pointer;
                transition: background 0.3s, transform 0.2s;
            }

                .login-container button:hover {
                    background: #4682b4;
                    transform: scale(1.05);
                }

            .login-container a {
                display: block;
                margin-top: 20px;
                text-decoration: none;
                color: #1e90ff;
                font-size: 14px;
                font-weight: bold;
                transition: color 0.3s;
            }

                .login-container a:hover {
                    color: #87cefa;
                }

            .login-container .brand {
                font-size: 36px;
                font-weight: bold;
                margin-bottom: 20px;
            }
    </style>
</head>
<body>
    <div class="login-container">
        <div class="brand">SINAV NOT SİSTEMİ</div>
        <h1>Giriş Yap</h1>
        <form action="Log.aspx" method="post">

             <input type="text" name="username" placeholder="Kullanıcı Adı" required>
            <input type="password" name="password" placeholder="Şifre" required>
           
            <button type="submit">Giriş Yap</button>
        </form>
        <a href="#">Şifremi Unuttum</a>

    </div>

</body>
</html>

