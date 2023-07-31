import React, { useEffect, useState } from 'react';
import axios from 'axios';
import './Registration.css';
import $ from 'jquery';


function Registration() {
  const [formData, setFormData] = useState({
    name: '',
    surname: '',
    age: '',
    email: '',
    password: ''
  });

  const handleChange = (e) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();

    axios.post('http://localhost:5052/api/User', formData)
      .then(response => {
        console.log('User added:', response.data);

        setFormData({
          name: '',
          surname: '',
          age: '',
          email: '',
          password: ''
        });

        window.location.href = '/';
      })
      .catch(error => {
        console.error('Error adding user:', error);
      });
  };


  useEffect(() => {
    document.title = 'SOCKS BOX - Registration'; 
  }, []);

  const handleHamburgerClick = () => {
    $('.drop5').click(function () {
      $('.dropdown5').toggle();
    });
  };

  window.addEventListener('resize', function () {
    if (window.innerWidth > 1180) {
      const dropdownElement = document.querySelector('.menu-container5');
      if (dropdownElement) {
        dropdownElement.style.display = 'none';
      }
    }
  });

  window.addEventListener('resize', function () {
    if (window.innerWidth < 1180) {
      const dropdownElement = document.querySelector('.menu-container5');
      if (dropdownElement) {
        dropdownElement.style.display = 'block';
      }
    }
  });

  function showContact() {
    document.getElementById('contactWindow5').style.display = 'block';
  }

  function hideContact() {
    document.getElementById('contactWindow5').style.display = 'none';
  }

  useEffect(() => {
    handleHamburgerClick();
    return () => {
      $('.drop5').off('click');
    };
  }, []);

  return (
    <div>
    
      <div className="header-section5">
        <div className="nav5">
          <div className="container15">
            <nav role="navigation">
              <img src="/images/logo.png" width="150" alt="SocksBoxLogo" className="image-logo5" />
              <a href="/" aria-current="page" className="menu5 current5">
                Home
              </a>
              <a href="/about" className="menu5">
                About US
              </a>
              <a href="/products" className="menu5">
                PRODUCTS
              </a>
              <a href="/cart" className="menu5">
                CART
              </a>
              
              <div className="menu-container5">
                <img src="/images/menu.jpg" alt="Menu" style={{ width: '70px', height: '70px' }} className="image-menu5 drop5" />
                <ul className="menu-list5 dropdown5">
                  <li>
                    <a href="/" aria-current="page" className="menu5 current5 dropdown5">
                      Home
                    </a>
                  </li>
                  <li>
                    <a href="/about" className="menu5 dropdown5">
                      About US
                    </a>
                  </li>
                  <li>
                    <a href="/products" className="menu5 dropdown5">
                      PRODUCTS
                    </a>
                  </li>
                  <li>
                    <a href="/cart" className="menu5 dropdown5">
                      CART
                    </a>
                  </li>
                  
                </ul>
              </div>
            </nav>
          </div>
        </div>
      
      <div className="registration5">
        <div id="text_register5">Create new account to join us!</div>
        <form onSubmit={handleSubmit} method="POST">
          <label htmlFor="name5">First Name:<br /></label>
          <input type="text" name="name" id="name5" value={formData.name} onChange={handleChange} required/><br /><br />

          <label htmlFor="surname5">Surname:<br /></label>
          <input type="text" name="surname" id="surname5" value={formData.surname} onChange={handleChange} required /><br /><br />

          <label htmlFor="age5">Age:<br /></label>
          <input type="number" name="age" id="age5" min="0" max="99" value={formData.age} onChange={handleChange} required /><br /><br />
          <label htmlFor="email15">Email:<br /></label>
          <input type="email" name="email" id="email15" value={formData.email} onChange={handleChange} required /><br /><br />

          <label htmlFor="password15">Password:<br /></label>
          <input type="password" name="password" id="password15" value={formData.password} onChange={handleChange} required /><br /><br />

          <input type="submit" id="submit15" value="Register" />
          <div id="accept_text5">
            <br /><br />By clicking the "Register" button, you accept the terms and conditions of the SocksBox service.
            In order to ensure that you have access to all the opportunities provided by your participation in the
            loyalty program, we will process your personal data in accordance with the SocksBox privacy policy.
          </div>
        </form>
      </div>
    
      <div className="footer-section5">
        <div className="logo-text5">&copy; SOCKS BOX 2023</div>
        <button href="#" className="menu5 footer-link5 contact5" onClick={showContact}>
          Contact
        </button>
        <a href="/policy" className="menu5 footer-link5">
          Privacy policy
        </a>
      </div>
      <div id="contactWindow5">
        <button className="close-button5" onClick={hideContact}>
          X
        </button>

        <h3>If you have any questions contact us!</h3>
        <p>You can write to us on facebook, instagram or even snapchat :D</p>
        <b>@SocksBoxSocialMedia</b>
        <p>
          If you prefer emails: <b><a href="mailto:socksbox.contact@gmail.com">socksbox.contact@gmail.com</a></b>
        </p>
        <br />
        <p>You can also call us at <b>100-200-300</b></p>
        <p>We make sure to check new messages as quick as we can :D</p>
      </div>
    </div>
  </div>
  );
}

export default Registration;
