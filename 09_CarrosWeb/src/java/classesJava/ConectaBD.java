/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package classesJava;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Fsociety
 */
public class ConectaBD {
    //Classe que faz a conexão com o banco de dados
    private static Connection conexao; 
    private static final String URL_CONEXAO ="jdbc:mysql://localhost:1080/bdCarros"; // Criação de uma constante, onde só terá seu valor defindo no inicio.
    //Por convenção, constantes são em maiusculo
    // jdbc é onde é colocado o nome do servidor, no caso o localhost
    private static final String USUARIO ="root"; // root é o usuário padrão do xamp 
    private static final String SENHA = null; 
    private static final String DRIVERBD = "com.mysql.jdbc.Driver";
    
    //Método para fazer a conexão 
    
    public static Connection getConexao(){
        // Verifica se a conexao é nula, caso sim carrega o driver 
       // E gera a conexão através do DriverManager, onde é passado o endereço(URL_CONEXAO), usuário e senha
        if(conexao == null){ 
            try {
                Class.forName(DRIVERBD); 
                conexao = DriverManager.getConnection(URL_CONEXAO, USUARIO, SENHA);
            } catch (ClassNotFoundException | SQLException ex) {
                Logger.getLogger(ConectaBD.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
        return conexao; 
    }
    
    public static void fechaConexao(){ 
        if(conexao!=null){
            try {
                conexao.close();
            } catch (SQLException ex) {
                Logger.getLogger(ConectaBD.class.getName()).log(Level.SEVERE, null, ex);
            }
            conexao = null; 
        }
    }
}
