
package desenvolvimento;
   
import java.text.DecimalFormat;
import javax.faces.bean.ManagedBean;

    @ManagedBean
    

public class calculo {
    private float km, litros, consumo; 
    public String mensagem; 
    public String msg; 
    

DecimalFormat df = new DecimalFormat("##.##"); 
    
public void calcular(){
    consumo = km / litros; 
    
    if (consumo>= 10 ){
        mensagem ="Consumo:  " + df.format(consumo) ; 
         msg =  "Classificação: Consumo Ideal!"; 
       }else if(consumo < 10) {
          mensagem ="Consumo:  " + df.format(consumo) ;  
          msg =  "Classificação: Consumo Alto!"; 
       }
}

public void limpar(){
    km = 0;
    litros = 0;
    consumo = 0; 
    mensagem = ""; 
    
           
}

    public String getMsg() {
        return msg;
    }

    public void setMsg(String msg) {
        this.msg = msg;
    }

    public float getKm() {
        return km;
    }

    public void setKm(float km) {
        this.km = km;
    }

    public float getLitros() {
        return litros;
    }

    public void setLitros(float litros) {
        this.litros = litros;
    }

    public float getConsumo() {
        return consumo;
    }

    public void setConsumo(float consumo) {
        this.consumo = consumo;
    }

    public String getMensagem() {
        return mensagem;
    }

    public void setMensagem(String mensagem) {
        this.mensagem = mensagem;
    }

    public DecimalFormat getDf() {
        return df;
    }

    public void setDf(DecimalFormat df) {
        this.df = df;
    }

}
