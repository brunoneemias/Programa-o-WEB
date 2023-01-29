
package desenvolvimento;

import java.text.DecimalFormat;
import javax.faces.bean.ManagedBean;

    @ManagedBean
    
public class Calculo {
       private float nota1, nota2, nota3, media; 
       private String mensagem; 
       
     DecimalFormat df = new DecimalFormat("##.##"); 
    public void media(){
        media = (nota1 + nota2 + nota3) / 3; 
        
        if (media >= 5 ) {
            mensagem ="Média: "+ df.format(media) + "   Aluno Aprovado!"; 
        }else if( media < 5 & media >= 2) { 
            mensagem = "Média: "+ df.format(media)+ "   Aluno de recuperação!";
        }else if(media < 2 ) { 
            mensagem = "Média: "+ df.format(media)+ "   Aluno reprovado!" ; 
        }
        
    }

    public float getNota1() {
        return nota1;
    }

    public void setNota1(float nota1) {
        this.nota1 = nota1;
    }

    public float getNota2() {
        return nota2;
    }

    public void setNota2(float nota2) {
        this.nota2 = nota2;
    }

    public float getNota3() {
        return nota3;
    }

    public void setNota3(float nota3) {
        this.nota3 = nota3;
    }

    public float getMedia() {
        return media;
    }

    public void setMedia(float media) {
        this.media = media;
    }

    public String getMensagem() {
        return mensagem;
    }

    public void setMensagem(String mensagem) {
        this.mensagem = mensagem;
    }
    
    public void limpar(){
        nota1 = 0; 
        nota2 = 0;
        nota3 = 0; 
        media = 0; 
        mensagem = "";
        
    }
}



