import React from 'react';
import "./sidebar.sass"

function Sidebar(props){
  let categories = props.items;
  var q = 0;
  let newCategories = categories.map((item) => {
    if(q === 0){
      q++
      return (<li className='active' key = {q} >{item}</li>);
    }else{
      q++
      return (<li key = {q}>{item}</li>);
    }
  })
  return(
    <div className="sidebar-container">
      <div className="sidebar__profile">
        <img alt="Profile" src="/images/profile.jpg" />
        <div>
          <span className="name">Алексей Саракуз</span>
          <span className="worker">Volunteer</span>
        </div>
      </div>
      <ul>
        {newCategories}
      </ul>
    </div>
  )
}

export default Sidebar;
