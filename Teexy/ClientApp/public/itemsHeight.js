window.onload = function(){
  if(window.innerWidth > 500){
    var itemsCol = document.getElementsByClassName('item__description-container');
    var maxHeight = -1;
    for(var i = 0; i < itemsCol.length; i++){
      if(itemsCol[i].clientHeight > maxHeight){
        maxHeight = itemsCol[i].clientHeight;
      }
    }

    for(var i = 0; i < itemsCol.length; i++){
      itemsCol[i].style.height = maxHeight + "px";
    }
  }
}
