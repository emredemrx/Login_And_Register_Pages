body {
  background-image: url("../image/arka.jpg");
  background-size: cover;
  background-repeat: no-repeat;
  background-position: center center; }
  body .login-background {
    background-size: cover;
    min-height: 100vh;
    width: 100vw;
    background-color: rgba(0, 0, 0, 0.363); }
  body .loginArea {
    position: absolute;
    padding: 0;
    top: calc(50% - 220px);
    left: calc(50% - 220px);
    min-width: 400px;
    min-height: 550px;
    background-color: rgba(27, 27, 27, 0.781);
    border-radius: 15px; }
    body .loginArea .loginTencere {
      width: 120px;
      position: absolute;
      top: -60px;
      left: calc(50% - 60px); }
  body .loginArea:before {
    background-image: url("/images/tencere.png"); }

@keyframes spin {
  from {
    transform: rotate(0deg); }
  to {
    transform: rotate(360deg); } }

/*# sourceMappingURL=login.cs.map */
