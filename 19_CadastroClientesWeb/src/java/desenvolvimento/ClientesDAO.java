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
public class ClientesDAO {
    String sql;
    Connection conexao;
    PreparedStatement ps;
    ResultSet rs;
    
    public void mensagem(String msg){
        FacesContext.getCurrentInstance().addMessage(null, new FacesMessage(FacesMessage.SEVERITY_INFO, "", msg));
    }
    
    public void salvar(Clientes cliente){
        try {
            conexao = ConectaBD.getConexao();
            sql = "insert into tbCadastro (Nome, RG, CPF, Celular, Email, CEP, Endereco, Cidade, Profissao) values (?,?,?,?,?,?,?,?,?)";
            ps = conexao.prepareStatement(sql); // Prepara o banco para consulta, verifica que existem 4 campos para inserção de dados
            ps.setString(1, cliente.getNome());
            ps.setInt(2, cliente.getRg());
            ps.setInt(3, cliente.getCpf());
            ps.setString(4, cliente.getCelular());
            ps.setString(5, cliente.getEmail());
            ps.setInt(6, cliente.getCep());
             ps.setString(7, cliente.getEndereco());
            ps.setString(8, cliente.getCidade());
            ps.setString(9, cliente.getProfissao());
            ps.execute();
            ConectaBD.fechaConexao();
            mensagem("Carro cadastrado com sucesso!");
        } catch (SQLException ex) {
            Logger.getLogger(ClientesDAO.class.getName()).log(Level.SEVERE, null, ex);
            mensagem("Erro ao cadastrar!");
        }
    }
      
      public void editar(Clientes cliente){
        try {
            conexao = ConectaBD.getConexao();
            sql = "update tbCadastro set Nome = ?, RG = ?, CPF = ?, Celular = ?, Email = ?, CEP = ?, Endereco = ?, Cidade = ?, Profissao = ? where idCliente = ?";
            ps = conexao.prepareStatement(sql);
            ps.setString(1, cliente.getNome());
            ps.setInt(2, cliente.getRg());
            ps.setInt(3, cliente.getCpf());
            ps.setString(4, cliente.getCelular());
            ps.setString(5, cliente.getEmail());
            ps.setInt(6, cliente.getCep());
            ps.setString(7, cliente.getEndereco());
            ps.setString(8, cliente.getCidade());
            ps.setString(9, cliente.getProfissao());
            ps.setInt(10, cliente.getId());
            ps.execute();
            ConectaBD.fechaConexao();
            mensagem("Carro alterado com sucesso!");
        } catch (SQLException ex) {
            Logger.getLogger(ClientesDAO.class.getName()).log(Level.SEVERE, null, ex);
            mensagem("Erro ao alterar!");
        }
    }
      
       public void excluir(int id){
        try {
            conexao = ConectaBD.getConexao();
            sql = "delete from tbCadastro where idCliente = ?";
            ps = conexao.prepareStatement(sql);
            ps.setInt(1, id);
            ps.execute();
            ConectaBD.fechaConexao();
            mensagem("Carro excluído com sucesso!");
        } catch (SQLException ex) {
            Logger.getLogger(ClientesDAO.class.getName()).log(Level.SEVERE, null, ex);
            mensagem("Erro ao excluir!");
        }
    }
       
       public List<Clientes> listar(){
        try {
            conexao = ConectaBD.getConexao();
            sql = "select * from tbCadastro";
            ps = conexao.prepareStatement(sql);
            rs = ps.executeQuery();
            
            List<Clientes> listaClientes = new ArrayList<>();
            while(rs.next()){
                Clientes cli = new Clientes();
                cli.setId(rs.getInt("idCliente"));
                cli.setNome(rs.getString("Nome"));
                cli.setRg(rs.getInt("RG"));
                cli.setCpf(rs.getInt("CPF"));
                cli.setCelular(rs.getString("Celular"));
                cli.setEmail(rs.getString("Email"));
                cli.setCep(rs.getInt("CEP"));
                cli.setEndereco(rs.getString("Endereco"));
                cli.setCidade(rs.getString("Cidade"));
                cli.setProfissao(rs.getString("Profissao"));
                listaClientes.add(cli);
            }
            return listaClientes;
            
        } catch (SQLException ex) {
            Logger.getLogger(ClientesDAO.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
    }
   
}
