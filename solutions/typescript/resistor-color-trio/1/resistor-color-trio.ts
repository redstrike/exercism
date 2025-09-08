export function decodedResistorValue(resistorColors: [string, string, string]): string {
  const [c1, c2, c3] = resistorColors;
  const resistanceValue = parseInt(`${COLORS[c1]}${COLORS[c2]}${ZEROS[c3]}`);
  
  if (resistanceValue >= 1_000_000_000) {
    return `${resistanceValue / 1_000_000_000} gigaohms`;
  }
  if (resistanceValue >= 1_000_000) {
    return `${resistanceValue / 1_000_000} megaohms`;
  }
  if (resistanceValue >= 1_000) {
    return `${resistanceValue / 1_000} kiloohms`;
  }
  return `${resistanceValue} ohms`;
}

const ZEROS: Record<string, string> = {
  black: '',
  brown: '0',
  red: '00',
  orange: '000',
  yellow: '0000',
  green: '00000',
  blue: '000000',
  violet: '0000000',
  grey: '00000000',
  white: '000000000'
};

const COLORS: Record<string, number> = {
  black: 0,
  brown: 1,
  red: 2,
  orange: 3,
  yellow: 4,
  green: 5,
  blue: 6,
  violet: 7,
  grey: 8,
  white: 9
};
