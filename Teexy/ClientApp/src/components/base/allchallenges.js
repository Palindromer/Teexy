import React from 'react';
import ChallengeItem from './ChallengeItem'

class Allchallenges extends React.Component{
  constructor(){
    super();
    // fetch('api/SampleData/WeatherForecasts')
    //   .then(response => response.json())
    //   .then(data => {
    //     this.setState({ forecasts: data, loading: false });
    //   });
  }

  render(){
    var info = [
      {
        title: "Посадити дерево",
        processNum: 586,
        score: 91,
        imgSrc: "logo1.jpg",
        id: 1
      },
      {
        title: "Посадити дерево",
        processNum: 5816,
        score: 91,
        imgSrc: "logo2.jpg",
        id: 2
      },
      {
        title: "Посадити дерево",
        processNum: 586,
        score: 91,
        imgSrc: "logo3.jpg",
        id: 3
      },
      {
        title: "Посадити дерево",
        processNum: 586,
        score: 91,
        imgSrc: "logo4.jpg",
        id: 4
      },
      {
        title: "Посадити дерево",
        processNum: 586,
        score: 91,
        imgSrc: "logo5.jpg",
        id: 5
      },
      {
        title: "Посадити дерево",
        processNum: 586,
        score: 91,
        imgSrc: "logo6.jpg",
        id: 6
      },
      {
        title: "Посадити дерево",
        processNum: 586,
        score: 91,
        imgSrc: "logo7.jpg",
        id: 7
      },
      {
        title: "Посадити дерево",
        processNum: 586,
        score: 91,
        imgSrc: "logo1.jpg",
        id: 8
      },
      {
        title: "Посадити дерево",
        processNum: 586,
        score: 91,
        imgSrc: "logo2.jpg",
        id: 9
      },
      {
        title: "Посадити дерево",
        processNum: 586,
        score: 91,
        imgSrc: "logo3.jpg",
        id: 10
      },
      {
        title: "Посадити дерево",
        processNum: 586,
        score: 91,
        imgSrc: "logo4.jpg",
        id: 11
      }
    ]
    let mainPage = [];
    mainPage = info.map(function(item){
      return (
        <ChallengeItem imgSrc = {item.imgSrc} key = {item.id} title = {item.title} processNum = {item.processNum} score = {item.score} />
      );
    })
    return (
      <div className="challenges-container">
      {
        mainPage
      }
      </div>
    )
  }
}

export default Allchallenges;
