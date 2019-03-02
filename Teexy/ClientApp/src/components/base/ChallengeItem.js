import React from 'react';
import "./ChallengeItem.sass"

function ChallengeItem(props){
  const src = "./images/" + props.imgSrc;
  return (
    <div className="item-container">
      <div className="item__left">
        <img src={src}/>
      </div>
      <div className="item__right">
        <div>
          <h2>{props.title}</h2>
          <p>Приєдналося вже {props.processNum} людей</p>
        </div>
        <p className="item__score">+ {props.score}</p>
      </div>
      <div className="clearfix"></div>
    </div>
  )
}


export default ChallengeItem;
