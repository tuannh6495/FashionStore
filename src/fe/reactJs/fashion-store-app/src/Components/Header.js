import React, { useState } from "react";
import "../styles/Header.css";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import {faXmark} from '@fortawesome/free-solid-svg-icons'

const Header = () => {
  const [isVisible, setIsVisible] = useState(true);
  const handleClick = () => {
    setIsVisible(false);
  };
  return (
    <header className="container-fluid p-0">
      {isVisible && (
        <div className="row g-0">
          <div className="col-12 header-section-1">
            <div className="row">
              <span>Sign up and get 20% off to your first order. </span>
              <span style={{ textDecorationLine: "underline" }}>
                Sign Up Now
              </span>
              <FontAwesomeIcon style={{ position: "absolute", cursor: "pointer" }} onClick={handleClick} icon={faXmark} />
            </div>

          </div>
        </div>
      )}
      <div className="row g-0">
        <div
          className="col-12"
          style={{ height: "96px", backgroundColor: "#FFF" }}
        >
          2{/* Content for the second section */}
        </div>
      </div>
      <div className="row g-0">
        <div
          className="col-12"
          style={{ height: "663px", backgroundColor: "#F2F0F1" }}
        >
          3{/* Content for the third section */}
        </div>
      </div>
      <div className="row g-0">
        <div
          className="col-12"
          style={{ height: "122px", backgroundColor: "#000" }}
        >
          4{/* Content for the fourth section */}
        </div>
      </div>
    </header>
  );
};

export default Header;
