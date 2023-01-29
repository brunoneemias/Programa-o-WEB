/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package desenvolvimento;

import javax.faces.bean.ManagedBean;

@ManagedBean
/**
 *
 * @author Fsociety
 */
public class CalculoAreaVolume {
 private float a,b,c,v,s;
    private String sup; 
    
 public void calculo(){
     v = a*b*c; 
     s = 2 * (a*b+a*c+b*c); 
     if(v>20){
         sup = "O volume é maior que 20cm³"; 
     }else if(v<20){
         sup = "O volume é menor que 20cm³"; 
     }else{
         sup = "O volume é igual a 20cm³";
     }
 }
 
 public void limpar(){
     v=0;
     a=0;
     b=0;
     c=0;
     s=0;
     sup=""; 
 }

    public float getA() {
        return a;
    }

    public void setA(float a) {
        this.a = a;
    }

    public float getB() {
        return b;
    }

    public void setB(float b) {
        this.b = b;
    }

    public float getC() {
        return c;
    }

    public void setC(float c) {
        this.c = c;
    }

    public float getV() {
        return v;
    }

    public void setV(float v) {
        this.v = v;
    }

    public float getS() {
        return s;
    }

    public void setS(float s) {
        this.s = s;
    }

    public String getSup() {
        return sup;
    }

    public void setSup(String sup) {
        this.sup = sup;
    }
 
}
