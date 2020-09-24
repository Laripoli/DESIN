import java.awt.EventQueue;
import java.awt.event.ActionEvent;

import javax.swing.JFrame;
import javax.swing.JPanel;
import java.awt.BorderLayout;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.SwingConstants;
import javax.swing.plaf.basic.BasicButtonListener;
import javax.swing.JButton;
import javax.swing.JPasswordField;
import java.awt.event.ActionListener;
import static javax.swing.JOptionPane.showMessageDialog;
public class main {
	private JFrame frame;
	private JTextField tfUser;
	private JPasswordField tfPass;
	private final String User = "Hola";
	private final String Pass = "Adios";
	/**
	 * Launch the application.
	 * @throws Exception 
	 */
	public static void main(String[] args) throws Exception {
		//MySqlAccess dao = new MySqlAccess();
		//dao.readDataBase();
		/**
		 * El tema de la base de datos no he logrado enchufarla asi que funciona con las constantes
		 */
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					main window = new main();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public main() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JLabel lblUsuario = new JLabel("Usuario");
		lblUsuario.setHorizontalAlignment(SwingConstants.TRAILING);
		lblUsuario.setBounds(100, 82, 71, 26);
		frame.getContentPane().add(lblUsuario);
		
		tfUser = new JTextField();
		tfUser.setBounds(181, 85, 86, 20);
		frame.getContentPane().add(tfUser);
		tfUser.setColumns(10);
		
		JLabel lblPass = new JLabel("Contraseña");
		lblPass.setHorizontalAlignment(SwingConstants.TRAILING);
		lblPass.setBounds(100, 127, 71, 14);
		frame.getContentPane().add(lblPass);
		
		tfPass = new JPasswordField();
		tfPass.setBounds(181, 124, 86, 20);
		frame.getContentPane().add(tfPass);
		
		JButton btnLogin = new JButton("Conectarse");
		btnLogin.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if(tfUser.getText().equals(User) && tfPass.getText().equals(Pass)) {
					showMessageDialog(null, "Correcto!");
				}
				else {
					showMessageDialog(null, "Usuario o contraseña incorrecto");
				}
			}
		});
		btnLogin.setBounds(150, 172, 138, 54);
		frame.getContentPane().add(btnLogin);
	}
}
