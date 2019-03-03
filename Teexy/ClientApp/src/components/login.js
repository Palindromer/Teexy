import React from 'react';
import './login.sass'

function LoginSocial(){
    return (
      <div className="login-container">
          <img alt = "dancer" className = "dancer" src = "/images/dancer.png"/>
          <img alt = "teexey" className = "teexy" src = "/images/teexy.png"/>
          <div className = "login-container login-container1"></div>
          <div className="social-buttons">
            <button className="facebook">facebook</button>
            <button className="instagram"><span><img src="/images/instagram.svg" alt="instagram"/></span>Instagram</button>
            <button className="google-auth">Google +</button>
          </div>
      </div>
    )
}

export default LoginSocial;
