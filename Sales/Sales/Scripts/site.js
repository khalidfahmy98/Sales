function addTofav (histo , user ) {
    var xhr = new XMLHttpRequest ();
    xhr.onreadystatechange = function () {
        if ( xhr.readyState == 4 && xhr.status == 200 ) {
            alert("تمت الإضافة إلى المفضلة ");
        }
    }
    xhr.open("POST","controls/users.php?do=adToFavs",true);
    xhr.setRequestHeader("Content-Type","application/x-www-form-urlencoded");
    xhr.send("histo="+histo+"&user="+user);
}
