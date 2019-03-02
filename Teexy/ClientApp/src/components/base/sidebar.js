import React from 'react';
import "./sidebar.sass"

function Sidebar(){
  return(
    <div className="sidebar-container">
      <div className="sidebar__profile">
        <img alt="Profile" src="/images/profile.jpg"/>
        <div>
          <span className="name">Алексей Саракуз</span>
          <span className="worker">Volunteer</span>
        </div>
      </div>
      <ul>
        <li>Все челенджи</li>
        <li>Самые новые</li>
        <li className = "active">В прогрессе</li>
        <li>Самые популярные</li>
      </ul>
    </div>
  )
}

export default Sidebar;
