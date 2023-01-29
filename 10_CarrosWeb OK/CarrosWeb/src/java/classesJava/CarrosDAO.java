/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package classesJava;

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
 * @author rafaelcergoli
 */
public class CarrosDAO {
    String sql;
    Connection conexao;
    PreparedStatement ps;
    ResultSet rs;
    
    public void mensagem(String msg){
        FacesContext.getCurrentInstance().addMessage(null, new FacesMessage(FacesMessage.SEVERITY_INFO, "", msg));
    }
    
    public void salvar(Carros carro){
        try {
            conexao = ConectaBD.getConexao();
            sql = "insert into tbcadastro (Nome, RG, CPF, Celular, Email, CEP, Endereco, Cidade, Profissao) values (?,?,?,?,?,?,?,?,?)";
            ps = conexao.prepareStatement(sql); // Prepara o banco para consulta, verifica que existem 4 campos para inserção de dados
            ps.setString(1, carro.getNome());
            ps.setInt(2, carro.getRg());
            ps.setInt(3, carro.getCpf());
            ps.setString(4, carro.getCelular());
            ps.setString(5, carro.getEmail());
            ps.setInt(6, carro.getCep());
            ps.setString(7, carro.getEndereco());
            ps.setString(8, carro.getCidade());
            ps.setString(9, carro.getProfissao());
            ps.execute();
            ConectaBD.fechaConexao();
            mensagem("Cliente cadastrado com sucesso!");
        } catch (SQLException ex) {
            Logger.getLogger(CarrosDAO.class.getName()).log(Level.SEVERE, null, ex);
            mensagem("Erro ao cadastrar!");
        }
    }
    
    public void editar(Carros carro){
        try {
            conexao = ConectaBD.getConexao();
            sql = "update tbcadastro set Nome = ?, RG = ?, CPF = ?, Celular = ?, Email = ?, CEP = ?, Endereco = ?, Cidade = ?, Profissao = ? where idCliente = ?";
            ps = conexao.prepareStatement(sql);
            ps.setString(1, carro.getNome());
            ps.setInt(2, carro.getRg());
            ps.setInt(3, carro.getCpf());
            ps.setString(4, carro.getCelular());
            ps.setString(5, carro.getEmail());
            ps.setInt(6, carro.getCep());
            ps.setString(7, carro.getEndereco());
            ps.setString(8, carro.getCidade());
            ps.setString(9, carro.getProfissao());
            ps.setInt(10, carro.getId());
            ps.execute();
            ConectaBD.fechaConexao();
            mensagem("Cliente alterado com sucesso!");
        } catch (SQLException ex) {
            Logger.getLogger(CarrosDAO.class.getName()).log(Level.SEVERE, null, ex);
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
            Logger.getLogger(CarrosDAO.class.getName()).log(Level.SEVERE, null, ex);
            mensagem("Erro ao excluir!");
        }
    }
    
    public List<Carros> listar(){
        try {
            conexao = ConectaBD.getConexao();
            sql = "select * from tbcadastro";
            ps = conexao.prepareStatement(sql);
            rs = ps.executeQuery();
            
            
            List<Carros> listaCliente = new ArrayList<>();
            while(rs.next()){
                Carros cli = new Carros();
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
                listaCliente.add(cli);
            }
            return listaCliente;
            
        } catch (SQLException ex) {
            Logger.getLogger(CarrosDAO.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
    }
}
