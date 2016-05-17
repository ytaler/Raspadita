using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raspa2016
{
    public class PostCript
    {
        public static string encabezado =
            "%!PS-Adobe-3.0" + "\n" +
            "%Creator: Desconocido" + "\n" +
            "%BeginProlog" + "\n" +
            "\n" +
            "/BD {bind def} bind def" + "\n" +
            "/MV { moveto } BD" + "\n" +
            "/RT { rotate } BD " + "\n" +
            "/TR { translate } BD" + "\n" +
            "/MM2PT {0.35294117647 div} BD " + "\n" +
            "/PT2MM {0.35294117647 mul} BD " + "\n" +
            "/CONCATENAR { 2 copy length exch length add string dup 4 2 roll 2 index 0 3 index putinterval exch length exch putinterval } BD"+"\n" +
            "/NUM2STR { /cantDecs exch def 20 string cvs (.) search { exch CONCATENAR exch dup length cantDecs sub dup 0 ge { pop 0 cantDecs getinterval }" +
            "{ abs {(0) CONCATENAR } repeat } ifelse CONCATENAR } { (.) CONCATENAR cantDecs {(0) CONCATENAR } repeat } ifelse dup dup length 1 sub get 46 eq " +
            "{ dup length 1 sub 0 exch getinterval } if } BD" + "\n" +
            "/IF { 1 index type (nametype) eq { } { [ 3 1 roll 0 0 3 -1 roll 0 0 ] } ifelse 1 index findfont dup length dict copy begin 2 index dup where" +
            "{ dup systemdict eq { exch cvn get /Encoding exch def } { /Encoding Encoding 256 array copy def exch cvn get [ exch exec { dup mark eq { pop" +
            "exit } { Encoding 3 1 roll [ 2 1 roll ] putinterval } ifelse } loop } ifelse } { pop } ifelse 1 index dup length string cvs 3 index" +
            "CONCATENAR cvn dup currentdict definefont pop end exch 3 -1 roll pop 3 -1 roll pop /selectfont load [ 4 1 roll ] cvx def } BD " +"\n" +
            "/Pdict << /. null def /arraytype { aload pop dup null ne {/ancho exch def}{pop}ifelse dup null ne {/intX exch def}{pop}ifelse dup null ne" +
            "{/intY exch def}{pop}ifelse } /stringtype { counttomark array astore /strings exch def } def /nametype { cvx exec } def /realtype { /gris" +
            "exch def } def /integertype { /rot exch def } def /i { /mostrar { dup show stringwidth pop neg intX add intY neg rmoveto } def } def /d"+
            " { /mostrar { dup stringwidth pop neg 0 rmoveto show intX intY neg rmoveto } def } def /c { /mostrar { dup stringwidth pop 2 div neg dup 0 "+
            "rmoveto exch show intX add intY neg rmoveto } def } def /j { /mostrar { dup stringwidth pop ancho exch sub cantSP dup 0 gt { div 0 32 4 -1"+
            " roll widthshow ancho neg intX add intY neg rmoveto } { pop pop dup show stringwidth pop neg intX add intY neg rmoveto } ifelse } def } "+
            "def >> def" +"\n" +
            "/P { Pdict begin /intY currentfont /ScaleMatrix get 3 get 1.2 mul def /intX 0 def /ancho 9999 def /gris 0 def /rot 0 def /mover {} def"+
            " /gris_actual currentgray def /strings [] def /cantSP -1 def i { dup [ eq { pop exit } if dup type (stringtype) eq { dup length 2 ge {"+
            " dup 0 2 getinterval (--) eq { dup length 2 sub 2 exch getinterval    dup /marcador exch def    /pdfmark where { pop } { /pdfmark "+
            "/cleartomark load def } ifelse [ /Title marcador /OUT pdfmark }if }if }if dup type exec } loop rot 0 ne { rot rotate } if gris 0.55"+
            " eq {1 0 0 setrgbcolor} {gris setgray} ifelse strings { dup stringwidth pop ancho gt { ( ) CONCATENAR /linea null def /cantSP -1 def "+
            "( ) { search { /palabra exch def linea dup null eq {pop ()}{( ) CONCATENAR} ifelse palabra CONCATENAR dup stringwidth pop ancho gt { "+
            "pop linea mostrar /linea palabra def /cantSP 0 def } { /linea exch def /cantSP cantSP 1 add def } ifelse } { pop /cantSP 0 def linea "+
            "mostrar exit } ifelse } loop } { mostrar } ifelse } forall gris_actual setgray rot 0 ne { rot neg rotate } if end } BD " +
            "\n";


    }
}
