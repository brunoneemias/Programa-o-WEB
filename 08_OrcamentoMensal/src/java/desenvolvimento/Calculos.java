
package desenvolvimento;

import java.util.ArrayList;
import java.util.List;
import javax.annotation.PostConstruct;
import javax.faces.bean.ManagedBean;
import org.primefaces.model.charts.ChartData;
import org.primefaces.model.charts.pie.PieChartDataSet;
import org.primefaces.model.charts.pie.PieChartModel;

/**
 *
 * @author Fsociety
 */

@ManagedBean
public class Calculos {
    double receita, alimentacao, transporte, saude, moradia, comprasG,fundo,outros, totaldespesas, 
            restante, f_alimentacao, f_transporte, f_saude, f_moradia, f_comprasG, f_fundo, f_outros; 
    
    private PieChartModel pieModel; 
        @PostConstruct
        public void init() {
              createPieModel();
}
      private void createPieModel() {
        pieModel = new PieChartModel();
          ChartData data = new ChartData();

         PieChartDataSet dataSet = new PieChartDataSet();
        List<Number> values = new ArrayList<>();
        values.add(receita);
        values.add(alimentacao);
        values.add(transporte);
        values.add(saude);
        values.add(moradia);
        values.add(comprasG);
        values.add(fundo);
        values.add(outros);
        dataSet.setData(values);

        List<String> bgColors = new ArrayList<>();
        bgColors.add("rgb(255, 99, 132)");
        bgColors.add("rgb(54, 162, 235)");
        bgColors.add("rgb(255, 205, 86)");
        bgColors.add("rgb(30,120,181)");
        bgColors.add("rgb(255, 128, 3)");
        bgColors.add("rgb(174, 198, 231)");
        bgColors.add("rgb(179, 70, 80)");
        bgColors.add("rgb(150, 40, 150)");
        dataSet.setBackgroundColor(bgColors);

        data.addChartDataSet(dataSet);
        List<String> labels = new ArrayList<>();
        labels.add("Receita");
        labels.add("Alimentação"); 
        labels.add("Transporte");
        labels.add("Saúde");
        labels.add("Moradia");
        labels.add("Compras Gerais");
        labels.add("Fundo Reserva");
        labels.add("Outros");
        data.setLabels(labels);

        pieModel.setData(data);
    }

     public PieChartModel getPieModel() {
        return pieModel;
    }
     
    public void calcular(){ 
        createPieModel();
        calculargastos(); 
    }
    
    public void calculargastos(){
        //General Calculus
        totaldespesas = alimentacao + transporte + saude + moradia + comprasG + fundo + outros;
        restante = receita - totaldespesas; 
        
        //Faixas 
        f_alimentacao = alimentacao/(totaldespesas); 
        f_comprasG = comprasG/(totaldespesas); 
        f_fundo = fundo/(totaldespesas); 
        f_moradia = moradia/(totaldespesas); 
        f_outros = outros/(totaldespesas); 
        f_saude = saude/(totaldespesas); 
        f_transporte = transporte/(totaldespesas); 
        
        
    }
    
    public void limpar(){ 
          totaldespesas = alimentacao = transporte = saude = moradia = comprasG = fundo = outros = receita =
                  restante = f_alimentacao =f_transporte = f_saude = f_moradia = f_comprasG = f_fundo = f_outros = 0;
          createPieModel();
    }

    public double getReceita() {
        return receita;
    }

    public void setReceita(double receita) {
        this.receita = receita;
    }

    public double getAlimentacao() {
        return alimentacao;
    }

    public void setAlimentacao(double alimentacao) {
        this.alimentacao = alimentacao;
    }

    public double getTransporte() {
        return transporte;
    }

    public void setTransporte(double transporte) {
        this.transporte = transporte;
    }

    public double getSaude() {
        return saude;
    }

    public void setSaude(double saude) {
        this.saude = saude;
    }

    public double getMoradia() {
        return moradia;
    }

    public void setMoradia(double moradia) {
        this.moradia = moradia;
    }

    public double getComprasG() {
        return comprasG;
    }

    public void setComprasG(double comprasG) {
        this.comprasG = comprasG;
    }

    public double getFundo() {
        return fundo;
    }

    public void setFundo(double fundo) {
        this.fundo = fundo;
    }

    public double getOutros() {
        return outros;
    }

    public void setOutros(double outros) {
        this.outros = outros;
    }

    public double getTotaldespesas() {
        return totaldespesas;
    }

    public void setTotaldespesas(double totaldespesas) {
        this.totaldespesas = totaldespesas;
    }

    public double getRestante() {
        return restante;
    }

    public void setRestante(double restante) {
        this.restante = restante;
    }

    public double getF_alimentacao() {
        return f_alimentacao;
    }

    public void setF_alimentacao(double f_alimentacao) {
        this.f_alimentacao = f_alimentacao;
    }

    public double getF_transporte() {
        return f_transporte;
    }

    public void setF_transporte(double f_transporte) {
        this.f_transporte = f_transporte;
    }

    public double getF_saude() {
        return f_saude;
    }

    public void setF_saude(double f_saude) {
        this.f_saude = f_saude;
    }

    public double getF_moradia() {
        return f_moradia;
    }

    public void setF_moradia(double f_moradia) {
        this.f_moradia = f_moradia;
    }

    public double getF_comprasG() {
        return f_comprasG;
    }

    public void setF_comprasG(double f_comprasG) {
        this.f_comprasG = f_comprasG;
    }

    public double getF_fundo() {
        return f_fundo;
    }

    public void setF_fundo(double f_fundo) {
        this.f_fundo = f_fundo;
    }

    public double getF_outros() {
        return f_outros;
    }

    public void setF_outros(double f_outros) {
        this.f_outros = f_outros;
    }
    
}

