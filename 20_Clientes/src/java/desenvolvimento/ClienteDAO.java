/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package desenvolvimento;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.faces.application.FacesMessage;
import javax.faces.context.FacesContext;

/**
 *
 * @author Fsociety
 */
public class ClienteDAO {
    String sql;
    Connection conexao;
    PreparedStatement ps;
    ResultSet rs;
    
    //Mensagem que indica se foi realizado a operação com sucesso ou não.
    public void mensagem(String msg){
        FacesContext.getCurrentInstance().addMessage(null, new FacesMessage(FacesMessage.SEVERITY_INFO, "", msg));
    }
    
    public void salvar (Cliente cliente){
        try {
            conexao = ConectaBD.getConexao();
            sql = "insert into tbCadastro (Nome, Celular, Email, Profissao) values (?,?,?,?)";
            ps = conexao.prepareStatement(sql); // Prepara o banco para consulta, verifica que existem 4 campos para inserção de dados
            ps.setString(1, cliente.getNome());
            ps.setString(2, cliente.getCelular());
            ps.setString(3, cliente.getEmail());
            ps.setString(4, cliente.getProfissao());
            ps.execute();
            ConectaBD.fechaConexao();
            mensagem("Cliente cadastrado com sucesso!");
        } catch (SQLException ex) {
            Logger.getLogger(ClienteDAO.class.getName()).log(Level.SEVERE, null, ex);
            mensagem("Erro ao cadastrar!");
        }
    }
    
    public void editar(Cliente cliente){
        try {
            conexao = ConectaBD.getConexao();
            sql = "update tbcadastro set Nome = ?,Celular = ?, Email = ?,Profissao = ? where idCliente = ?";
            ps = conexao.prepareStatement(sql);
            ps.setString(1, cliente.getNome());
            ps.setString(2, cliente.getCelular());
            ps.setString(3, cliente.getEmail());
            ps.setString(4, cliente.getProfissao());
            ps.setInt(5, cliente.getId());
            ps.execute();
            ConectaBD.fechaConexao();
            mensagem("Cliente alterado com sucesso!");
        } catch (SQLException ex) {
            Logger.getLogger(ClienteDAO.class.getName()).log(Level.SEVERE, null, ex);
            mensagem("Erro ao alterar!");
        }
    }
    
    public void excluir(int id){
        try {
            conexao = ConectaBD.getConexao();
            sql = "delete from tbcadastro where idCliente = ?";
            ps = conexao.prepareStatement(sql);
            ps.setInt(1, id);
            ps.execute();
            ConectaBD.fechaConexao();
            mensagem("Cliente excluído com sucesso!");
        } catch (SQLException ex) {
            Logger.getLogger(ClienteDAO.class.getName()).log(Level.SEVERE, null, ex);
            mensagem("Erro ao excluir!");
        }
    }
    
    public List<Cliente> listar(){
        try {
            conexao = ConectaBD.getConexao();
            sql = "select * from tbcadastro";
            ps = conexao.prepareStatement(sql);
            rs = ps.executeQuery();
            
            List<Cliente> listaCliente = new ArrayList<>();
            while(rs.next()){
                Cliente cli = new Cliente();
                cli.setId(rs.getInt("idCliente"));
                cli.setNome(rs.getString("Nome"));
                cli.setCelular(rs.getString("Celular"));
                cli.setEmail(rs.getString("Email"));
                cli.setProfissao(rs.getString("Profissao"));
                listaCliente.add(cli);
            }
            return listaCliente;
            
        } catch (SQLException ex) {
            Logger.getLogger(ClienteDAO.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
    }
    }
    

