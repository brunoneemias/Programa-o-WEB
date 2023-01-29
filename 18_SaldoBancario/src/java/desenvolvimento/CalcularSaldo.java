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
public class CalcularSaldo {
    private float n_conta, saldo, deb, cred;
    private String situation;  
    
    public void Calculo(){
        situation = "Saldo = 0"; 
        saldo = saldo + (deb+cred); 
        if(saldo > 0) {
            situation = "Saldo Positivo"; 
        }else if(saldo < 0)
        { 
            situation = "Saldo";
        }
    }
    
    public void Limpar(){ 
        saldo = 0; 
        deb = 0; 
        cred = 0; 
        n_conta = 0; 
    }

    public float getN_conta() {
        return n_conta;
    }

    public void setN_conta(float n_conta) {
        this.n_conta = n_conta;
    }

    public float getSaldo() {
        return saldo;
    }

    public void setSaldo(float saldo) {
        this.saldo = saldo;
    }

    public float getDeb() {
        return deb;
    }

    public void setDeb(float deb) {
        this.deb = deb;
    }

    public float getCred() {
        return cred;
    }

    public void setCred(float cred) {
        this.cred = cred;
    }

    public String getSituation() {
        return situation;
    }

    public void setSituation(String situation) {
        this.situation = situation;
    }
    
    
}
