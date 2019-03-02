window.onload = function(){
  if(window.innerWidth > 500){
    var itemsCol = document.getElementsByClassName('item__description-container');
    var maxHeight = -1;
    for(var i = 0; i < itemsCol.length; i++){
      console.log(itemsCol[i].clientHeight);
      if(itemsCol[i].clientHeight > maxHeight){
        maxHeight = itemsCol[i].clientHeight;
      }
    }
    console.log(maxHeight);

    for(var i = 0; i < itemsCol.length; i++){
      itemsCol[i].style.height = maxHeight + "px";
    }
  }
}
