/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package desenvolvimento;

import javax.faces.bean.ManagedBean;

/**
 *
 * @author rafaelcergoli
 */

@ManagedBean
public class CalculoPeso {
    private float altura, peso;
    private String sexo;
    
    public void calcular(){
        if(sexo.equals("M")){
            peso = (72.7f * altura) - 58;
        }
        else {
            peso = (62.1f * altura) - 44.7f;
        }   
    }
    
    public void limpar(){
        altura = 0;
        peso = 0;
        sexo = "";
    }

    public float getAltura() {
        return altura;
    }

    public void setAltura(float altura) {
        this.altura = altura;
    }

    public float getPeso() {
        return peso;
    }

    public void setPeso(float peso) {
        this.peso = peso;
    }

    public String getSexo() {
        return sexo;
    }

    public void setSexo(String sexo) {
        this.sexo = sexo;
    }
    
    
    
}
