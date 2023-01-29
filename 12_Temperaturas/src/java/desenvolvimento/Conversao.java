
package desenvolvimento;

import javax.faces.bean.ManagedBean;

    @ManagedBean 

public class Conversao {
    //Variaveis Celsius, fahrenheit e kelvin
    private float celsius, fahrenheit, kelvin; 
    private String mensagem; 
    
public void converter() {
    fahrenheit = (celsius * 5 / 9) + 32; 
    kelvin = celsius + 273; 
    
    if (celsius <= 15) {
        mensagem = "Temperatura fria";
    
    } else if (celsius <= 25 ){ 
        mensagem = "Temperatura amena"; 
        
    } else {
        mensagem = "Temperatura quente"; 
    }
}

public void limpar(){
    celsius = 0; 
    fahrenheit =0;
    kelvin = 0; 
    mensagem = ""; 
    
}

    public float getCelsius() {
        return celsius;
    }

    public void setCelsius(float celsius) {
        this.celsius = celsius;
    }

    public float getFahrenheit() {
        return fahrenheit;
    }

    public void setFahrenheit(float fahrenheit) {
        this.fahrenheit = fahrenheit;
    }

    public float getKelvin() {
        return kelvin;
    }

    public void setKelvin(float kelvin) {
        this.kelvin = kelvin;
    }

    public String getMensagem() {
        return mensagem;
    }

    public void setMensagem(String mensagem) {
        this.mensagem = mensagem;
    }

}
