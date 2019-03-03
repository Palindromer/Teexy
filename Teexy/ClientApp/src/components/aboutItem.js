import React from 'react'
import Sidebar from './base/sidebar'
import './aboutItem.sass'

class Itemabout extends React.Component{
  constructor(){
    super()
    this.state = {
      first: true
    }
    this.changeState1 = this.changeState1.bind(this)
    this.changeState2 = this.changeState2.bind(this)
  }

  changeState1(){
    this.setState({first: true})
  }

  changeState2(){
    this.setState({first: false})
  }

  render(){
    var title = "Зачем мне этот челендж?";
    var content = "Lorem ipsum dolorn sit ame, Lorem ipsum dolorn sit amet, Lorem ipsum dolorn sit ame, Lorem ipsum dolorn sit ame, Lorem ipsum dolorn sit ame, Lorem ipsum dolorn sit ame, Lorem ipsum dolorn sit ame, Lorem ipsum dolorn sit ame, Lorem ipsum dolorn sit ame, Lorem ipsum dolorn sit ame, Lorem ipsum dolorn sit ame, Lorem ipsum dolorn sit ame";
    var items = ["Статистика", "Описание челенджа", "Выложенные челенджи"]
    let aboutImageStyle = {backgroundImage: "url(/images/bg1.jpg)"};

    let descrClass = "about__description-content " + this.state.first;
    let provesClass = "about__description-proves " + !(this.state.first);
    let about__descrClass = "about__descr " + (this.state.first);
    let about__provesClass = "about__proves " + !(this.state.first);
    return(
      <div>
        <Sidebar items={items}/>
        <div className="about-container">
          <div className="about__background-image" style = {aboutImageStyle}>
            <h2>Посадить дерево для оздоровления планеты</h2>
            <div className="about__status">
              <div className="svgStatus-container">
                <svg version="1.1" id="Capa_1" xmlns="http://www.w3.org/2000/svg" x="0px" y="0px"
                   viewBox="0 0 512 512">
                 <path d="M256,0C114.617,0,0,114.615,0,256s114.617,256,256,256s256-114.615,256-256S397.383,0,256,0z M344.48,269.57l-128,80
                  c-2.59,1.617-5.535,2.43-8.48,2.43c-2.668,0-5.34-0.664-7.758-2.008C195.156,347.172,192,341.82,192,336V176
                  c0-5.82,3.156-11.172,8.242-13.992c5.086-2.836,11.305-2.664,16.238,0.422l128,80c4.676,2.93,7.52,8.055,7.52,13.57
                  S349.156,266.641,344.48,269.57z"
                  />
                </svg>
              </div>
              <span>Активный</span>
            </div>
            <div className="about__logo">
              <svg version="1.1" id="Capa_1" xmlns="http://www.w3.org/2000/svg"  x="0px" y="0px" viewBox="0 0 45.902 45.902">

                  <path d="M43.162,26.681c-1.564-1.578-3.631-2.539-5.825-2.742c1.894-1.704,3.089-4.164,3.089-6.912
                    c0-5.141-4.166-9.307-9.308-9.307c-4.911,0-8.932,3.804-9.281,8.625c4.369,1.89,7.435,6.244,7.435,11.299
                    c0,1.846-0.42,3.65-1.201,5.287c1.125,0.588,2.162,1.348,3.066,2.26c2.318,2.334,3.635,5.561,3.61,8.851l-0.002,0.067
                    l-0.002,0.057l-0.082,1.557h11.149l0.092-12.33C45.921,30.878,44.936,28.466,43.162,26.681z"/>
                  <path d="M23.184,34.558c1.893-1.703,3.092-4.164,3.092-6.912c0-5.142-4.168-9.309-9.309-9.309c-5.142,0-9.309,4.167-9.309,9.309
                    c0,2.743,1.194,5.202,3.084,6.906c-4.84,0.375-8.663,4.383-8.698,9.318l-0.092,1.853h14.153h15.553l0.092-1.714
                    c0.018-2.514-0.968-4.926-2.741-6.711C27.443,35.719,25.377,34.761,23.184,34.558z"/>
                  <path d="M6.004,11.374v3.458c0,1.432,1.164,2.595,2.597,2.595c1.435,0,2.597-1.163,2.597-2.595v-3.458h3.454
                    c1.433,0,2.596-1.164,2.596-2.597c0-1.432-1.163-2.596-2.596-2.596h-3.454V2.774c0-1.433-1.162-2.595-2.597-2.595
                    c-1.433,0-2.597,1.162-2.597,2.595V6.18H2.596C1.161,6.18,0,7.344,0,8.776c0,1.433,1.161,2.597,2.596,2.597H6.004z"/>
              </svg>
            </div>
            <div className="about__views">
              <div className="svgStatus-container">
              <svg version="1.1" id="Capa_1" fill="#4570E2" xmlns="http://www.w3.org/2000/svg"  x="0px" y="0px" viewBox="0 0 45.902 45.902">

                  <path fill="#4570E2" d="M43.162,26.681c-1.564-1.578-3.631-2.539-5.825-2.742c1.894-1.704,3.089-4.164,3.089-6.912
                    c0-5.141-4.166-9.307-9.308-9.307c-4.911,0-8.932,3.804-9.281,8.625c4.369,1.89,7.435,6.244,7.435,11.299
                    c0,1.846-0.42,3.65-1.201,5.287c1.125,0.588,2.162,1.348,3.066,2.26c2.318,2.334,3.635,5.561,3.61,8.851l-0.002,0.067
                    l-0.002,0.057l-0.082,1.557h11.149l0.092-12.33C45.921,30.878,44.936,28.466,43.162,26.681z"/>
                  <path fill="#4570E2" d="M23.184,34.558c1.893-1.703,3.092-4.164,3.092-6.912c0-5.142-4.168-9.309-9.309-9.309c-5.142,0-9.309,4.167-9.309,9.309
                    c0,2.743,1.194,5.202,3.084,6.906c-4.84,0.375-8.663,4.383-8.698,9.318l-0.092,1.853h14.153h15.553l0.092-1.714
                    c0.018-2.514-0.968-4.926-2.741-6.711C27.443,35.719,25.377,34.761,23.184,34.558z"/>
                  <path fill="#4570E2" d="M6.004,11.374v3.458c0,1.432,1.164,2.595,2.597,2.595c1.435,0,2.597-1.163,2.597-2.595v-3.458h3.454
                    c1.433,0,2.596-1.164,2.596-2.597c0-1.432-1.163-2.596-2.596-2.596h-3.454V2.774c0-1.433-1.162-2.595-2.597-2.595
                    c-1.433,0-2.597,1.162-2.597,2.595V6.18H2.596C1.161,6.18,0,7.344,0,8.776c0,1.433,1.161,2.597,2.596,2.597H6.004z"/>
              </svg>
              </div>
              <span>44,980</span>
            </div>
          </div>
          <div className="about__tabs">
            <div className={about__descrClass} onClick = {this.changeState1}><a>Описание челенджа</a></div>
            <div className={about__provesClass} onClick = {this.changeState2}><a>Выложенные челенджи</a></div>
            <div className="clearfix"></div>
            <div className={descrClass}>
              <h2>{title}</h2>
              <p>{content}</p>
            </div>
            <div className={provesClass}>
              123122312
            </div>
          </div>
        </div>
      </div>
    )
  }
}

export default Itemabout;
