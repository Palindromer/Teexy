import React from 'react';
import "./ChallengeItem.sass"

function ChallengeItem(props){
  const src = "/images/" + props.imgSrc;
  let containerClass = "item-container " + props.categorie;
  if(props.inProgress){
    containerClass += " inProgress"
  }
  return (
    <div className={containerClass} data-categorie = {props.categorie}>
      <div className="item__description-container">
        <div className="item__left-mobile">
          <img src={src} alt={props.title}/>
        </div>
        <div className="item__right">
          <div>
            <h2>{props.title}</h2>
            <p>Приєдналося вже {props.processNum} людей</p>
          </div>
          <p className="item__score">+ {props.score}</p>
        </div>
        <div className="item__left-desktop">
          <img src={src} alt={props.title}/>
        </div>
      </div>
      <div className="item__counters-desktop">
        <div className="item__progress">
          <span className="item__profile">
            <img src="/images/user.svg" alt="User"/>
          </span>
          <span>{props.processNum}</span>
        </div>
        <div className="item__score-desktop">
          <span className="item__profile">+</span>
          <span>{props.score}</span>
        </div>
        <div className="clearfix"></div>
      </div>
      <div className="clearfix"></div>
    </div>
  )
}


export default ChallengeItem;
