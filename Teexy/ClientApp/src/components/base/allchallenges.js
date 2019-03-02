import React from 'react';
import ChallengeItem from './ChallengeItem'
import Sidebar from './sidebar'
import { NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';

class Allchallenges extends React.Component{
  constructor(){
    super();
    this.state = {
      information: []
    }
    fetch('api/challenges/')
      .then(response => response.json())
      .then(data => {
        this.setState({ information: data, loading: false });
      });
  }

  render(){
    // var info = [
    //   {
    //     title: "Посадити дерево біля свого будинку",
    //     processNum: 76586,
    //     score: 91,
    //     imgSrc: "logo1.jpg",
    //     id: 1,
    //     categorie: "ecology",
    //     inProgress: false
    //   },
    //   {
    //     title: "21 push up challenge у підтримку солдатів",
    //     processNum: 125816,
    //     score: 300,
    //     imgSrc: "logo2.jpg",
    //     id: 2,
    //     categorie: "health",
    //     inProgress: false
    //   },
    //   {
    //     title: "Каждый день учи по 10 новых английских слов",
    //     processNum: 886,
    //     score: 391,
    //     imgSrc: "logo3.jpg",
    //     id: 3,
    //     categorie: "language",
    //     inProgress: true
    //   },
    //   {
    //     title: "Шаг 1. Научись смотреть девушке в глаза",
    //     processNum: 586,
    //     score: 151,
    //     imgSrc: "logo4.jpg",
    //     id: 4,
    //     categorie: "love",
    //     inProgress: false
    //   },
    //   {
    //     title: "Пожелай 'хорошего дня' первым 10 прохожим :)",
    //     processNum: 86,
    //     score: 41,
    //     imgSrc: "logo5.jpg",
    //     id: 5,
    //     categorie: "honour",
    //     inProgress: false
    //   },
    //   {
    //     title: "Посадити дерево",
    //     processNum: 586,
    //     score: 3,
    //     imgSrc: "logo6.jpg",
    //     id: 6,
    //     categorie: "volunteer",
    //     inProgress: true
    //   },
    //   {
    //     title: "Посадити дерево",
    //     processNum: 586,
    //     score: 12,
    //     imgSrc: "logo7.jpg",
    //     id: 7,
    //     inProgress: false
    //   },
    //   {
    //     title: "Посадити дерево",
    //     processNum: 586,
    //     score: 45,
    //     imgSrc: "logo1.jpg",
    //     id: 8,
    //     inProgress: false
    //   },
    //   {
    //     title: "Посадити дерево",
    //     processNum: 586,
    //     score: 64,
    //     imgSrc: "logo2.jpg",
    //     id: 9,
    //     inProgress: false
    //   },
    //   {
    //     title: "Посадити дерево",
    //     processNum: 586,
    //     score: 12,
    //     imgSrc: "logo3.jpg",
    //     id: 10,
    //     inProgress: false
    //   },
    //   {
    //     title: "Посадити дерево",
    //     processNum: 586,
    //     score: 50,
    //     imgSrc: "logo4.jpg",
    //     id: 11,
    //     inProgress: false
    //   }
    // ]
    //

    let info = this.state.information;
    
    let mainPage = [];
    let progres = 0;
    mainPage = info.map(function(item){
      const toLink = "/challenges/" + item.id;
      if(item.inProgress){
        progres++;
      }
      return (
          <NavLink key = {item.id} tag={Link} className="nav__item" to={toLink}>
            <ChallengeItem inProgress = {item.inProgress}
                           categorie = {item.categorie}
                           imgSrc = {item.imgSrc}
                           title = {item.title}
                           processNum = {item.processNum}
                           score = {item.score}
            />
          </NavLink>

      );
    })
    return (
      <div>
        <Sidebar progres = {progres}/>
        <div className="challenges-container">{
            mainPage
        }</div>
      </div>
    )
  }
}

export default Allchallenges;
