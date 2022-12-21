function Topla() 
{
    var gelendeger1 = document.getElementById("deger").value;
    var gelendeger2 = document.getElementById("deger2").value;
    alert(Number(gelendeger1) + Number(gelendeger2));
    document.getElementById("t").innerHTML="Sonuç" + " " + (Number(gelendeger1) + Number(gelendeger2));
    document.getElementById("deger").value=""; // İşlem yaptıktan sonra içi sıfırlanacak
    document.getElementById("deger2").value=""; // İşlem yaptıktan sonra içi sıfırlanacak
}
function Cikarma() 
{
    var gelendeger1 = document.getElementById("deger").value;
    var gelendeger2 = document.getElementById("deger2").value;
    alert(Number(gelendeger1) - Number(gelendeger2));
    document.getElementById("t").innerHTML="Sonuç" + " " + (Number(gelendeger1) - Number(gelendeger2));
    document.getElementById("deger").value=""; // İşlem yaptıktan sonra içi sıfırlanacak
    document.getElementById("deger2").value=""; // İşlem yaptıktan sonra içi sıfırlanacak
}
function Carpma() 
{
    var gelendeger1 = document.getElementById("deger").value;
    var gelendeger2 = document.getElementById("deger2").value;
    alert(Number(gelendeger1) * Number(gelendeger2));
    document.getElementById("t").innerHTML="Sonuç" + " " + (Number(gelendeger1) * Number(gelendeger2));
    document.getElementById("deger1").value=""; // İşlem yaptıktan sonra içi sıfırlanacak
    document.getElementById("deger2").value=""; // İşlem yaptıktan sonra içi sıfırlanacak
}
function Bolme() 
{
    var gelendeger1 = document.getElementById("deger").value;
    var gelendeger2 = document.getElementById("deger2").value;
    alert(Number(gelendeger1) / Number(gelendeger2));
    document.getElementById("t").innerHTML="Sonuç" + " " + (Number(gelendeger1) / Number(gelendeger2));
    document.getElementById("deger").value=""; // İşlem yaptıktan sonra içi sıfırlanacak
    document.getElementById("deger2").value=""; // İşlem yaptıktan sonra içi sıfırlanacak   
}




// switch-case ile yapılması
function dortislem(deger1) 
{
    var deger = deger1;
    switch (deger) {
      case "Topla":
        var gelendeger = document.getElementById("deger").value;
        var gelendeger1 = document.getElementById("deger2").value;
        document.getElementById("deger3").innerHTML = Number(gelendeger) + Number(gelendeger1);
  
        //   alert(Number(gelendeger) + Number(gelendeger1));
        document.getElementById("deger").value = "";
        document.getElementById("deger2").value = "";
        break;
      case "Çıkar":
        var gelendeger = document.getElementById("deger").value;
        var gelendeger1 = document.getElementById("deger2").value;
  
        //   alert(Number(gelendeger) - Number(gelendeger1));
        document.getElementById("deger3").innerHTML = Number(gelendeger) - Number(gelendeger1);
        document.getElementById("deger").value = "";
        document.getElementById("deger2").value = "";
        break;
      case "Çarpma":
        var gelendeger = document.getElementById("deger").value;
        var gelendeger1 = document.getElementById("deger2").value;
  
        //   alert(Number(gelendeger) * Number(gelendeger1));
        document.getElementById("deger3").innerHTML = Number(gelendeger) * Number(gelendeger1);
        document.getElementById("deger").value = "";
        document.getElementById("deger2").value = "";
        break;
      case "Bolme":
        var gelendeger = document.getElementById("deger").value;
        var gelendeger1 = document.getElementById("deger2").value;
        document.getElementById("deger3").innerHTML = Number(gelendeger) / Number(gelendeger1);
  
        //   alert(Number(gelendeger) / Number(gelendeger1));
        document.getElementById("deger").value = "";
        document.getElementById("deger2").value = "";
        break;
      default:
        alert("Tanımsız");
        break;
    }
  }

